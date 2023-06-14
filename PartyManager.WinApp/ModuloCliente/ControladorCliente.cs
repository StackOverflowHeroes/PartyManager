using PartyManager.Dominio.ModuloCliente;

namespace PartyManager.WinApp.ModuloCliente
{
     public class ControladorCliente : ControladorBase
     {
          private IRepositorioCliente repoCliente;
          private TabelaClienteControl tabelaCliente;

          public ControladorCliente(IRepositorioCliente repoCliente)
          {
               this.repoCliente = repoCliente;
          }

          public override string ToolTipInserir => "Inserir Cliente";

          public override string ToolTipEditar => "Editar Cliente";

          public override string ToolTipDeletar => "Deletar Cliente";

          public override void Deletar()
          {
               Cliente cliente = ObterClienteSelecionado();

               if (cliente == null)
               {
                    MessageBox.Show($"Selecione um cliente primeiro!",
                        "Exclusão de Clientes",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    return;
               }

               DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o cliente {cliente.nome}?", "Exclusão de Clientes",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

               if (opcaoEscolhida == DialogResult.OK)
                    repoCliente.Deletar(cliente);

               CarregarClientes();

               if (opcaoEscolhida == DialogResult.OK)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Cliente deletado com sucesso!", TipoStatusEnum.Sucesso);
          }

          private Cliente ObterClienteSelecionado()
          {
               int id = tabelaCliente.ObterIdSelecionado();
               return repoCliente.SelecionarPorId(id);
          }

          public override void Editar()
          {
               Cliente cliente = ObterClienteSelecionado();

               if (cliente == null)
               {
                    MessageBox.Show($"Selecione um cliente primeiro!",
                        "Edição de Clientes",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    return;
               }

               TelaClienteForm telaCliente = new TelaClienteForm();
               telaCliente.Text = "Edição de Clientes";
               telaCliente.ConfigurarTela(cliente);


               DialogResult opcaoEscolhida = telaCliente.ShowDialog();

               if (opcaoEscolhida == DialogResult.OK)
               {
                    Cliente clienteAtualizado = telaCliente.ObterCliente();
                    repoCliente.Editar(clienteAtualizado.id, clienteAtualizado);
               }

               CarregarClientes();

               if (opcaoEscolhida == DialogResult.OK)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Cliente editado com sucesso!", TipoStatusEnum.Sucesso);

          }

          public override void Inserir()
          {
               TelaClienteForm telaCliente = new TelaClienteForm();

               DialogResult opcaoEscolhida = telaCliente.ShowDialog();

               if (opcaoEscolhida == DialogResult.OK)
               {
                    Cliente cliente = telaCliente.ObterCliente();
                    repoCliente.Inserir(cliente);
               }

               CarregarClientes();

               if (opcaoEscolhida == DialogResult.OK)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Cliente inserido com sucesso!", TipoStatusEnum.Sucesso);
          }

          private void CarregarClientes()
          {
               List<Cliente> clientes = repoCliente.SelecionarTodos();
               tabelaCliente.AtualizarRegistros(clientes);
               TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {clientes.Count} cliente(s)", TipoStatusEnum.Visualizando);
          }

          public override UserControl ObterListagem()
          {
               if (tabelaCliente == null)
                    tabelaCliente = new TabelaClienteControl();

               CarregarClientes();

               return tabelaCliente;
          }

          public override string ObterTipoCadastro()
          {
               return "Cadastros de Clientes";
          }
     }
}
