using PartyManager.Dominio.ModuloAluguel;
using PartyManager.Dominio.ModuloCliente;

namespace PartyManager.WinApp.ModuloCliente
{
     public class ControladorCliente : ControladorBase
     {
          private IRepositorioCliente repoCliente;
          private IRepositorioAluguel repoAluguel;
          private TabelaClienteControl tabelaCliente;

          public ControladorCliente(IRepositorioCliente repoCliente, IRepositorioAluguel repoAluguel)
          {
               this.repoCliente = repoCliente;
               this.repoAluguel = repoAluguel;
          }

          public override string ToolTipInserir => "Inserir Cliente";

          public override string ToolTipEditar => "Editar Cliente";

          public override string ToolTipDeletar => "Deletar Cliente";

          public override string ToolTipVisualizarHistorico => "Histórico Cliente";

          public override bool VisualizarHistoricoHabilitado => true;

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

               if (repoAluguel.ExistePagamentoPendente())
               {
                    TelaPrincipalForm.Instancia.AtualizarRodape("Cliente possui aluguéis em aberto!", TipoStatusEnum.Erro);
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
               telaCliente.PegarListaNome(repoCliente.SelecionarTodos());
               DialogResult opcaoEscolhida = telaCliente.ShowDialog();

               if (opcaoEscolhida == DialogResult.OK)
               {
                    Cliente cliente = telaCliente.ObterCliente();
                    List<Cliente> clientes = repoCliente.SelecionarTodos();
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

          public override void VisualizarHistorico()
          {
               Cliente cliente = ObterClienteSelecionado();

               if (cliente == null)
               {
                    MessageBox.Show($"Selecione um cliente primeiro!",
                        "Histórico de Aluguéis",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
               }
               if (cliente.alugueis.Count() == 0)
               {
                    MessageBox.Show($"Cliente não possui aluguéis cadastrados!",
                        "Histórico de Aluguéis",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
               }

               TelaHistoricoClienteForm telaHistorico = new TelaHistoricoClienteForm(cliente);
               telaHistorico.ShowDialog();
          }

          public override string ObterTipoCadastro()
          {
               return "Cadastros de Clientes";
          }
     }
}
