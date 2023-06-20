using PartyManager.Dominio.ModuloCliente;
using PartyManager.Dominio.ModuloFesta;
using PartyManager.Dominio.ModuloTema;

namespace PartyManager.WinApp.ModuloFesta
{
     public class ControladorFesta : ControladorBase
     {
          private IRepositorioCliente repositorioCliente;
          private IRepositorioTema repositorioTema;
          private IRepositorioFesta repoFesta;
          private TabelaFestaControl tabelaFesta;

          public ControladorFesta(IRepositorioFesta repoFesta, IRepositorioCliente repositorioCliente, IRepositorioTema repositorioTema)
          {
               this.repoFesta = repoFesta;
               this.repositorioCliente = repositorioCliente;
               this.repositorioTema = repositorioTema;

          }
          public override string ToolTipInserir => "Inserir Festa";

          public override string ToolTipEditar => "Editar Festa";

          public override string ToolTipDeletar => "Deletar Festa";

          public override void Deletar()
          {
               Festa festaSeleciado = ObterFestaSelecionado();

               if (festaSeleciado == null)
               {
                    MessageBox.Show($"Selecione uma festa primeiro!",
                        "Exclusão de Festas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    return;
               }
               DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a festa {festaSeleciado}?", "Exclusão de Festas",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

               if (opcaoEscolhida == DialogResult.OK)
                    repoFesta.Deletar(festaSeleciado);


               CarregarFestas();

               if (opcaoEscolhida == DialogResult.OK)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Festa deletada com sucesso!", TipoStatusEnum.Sucesso);
          }
          private Festa ObterFestaSelecionado()
          {
               int id = tabelaFesta.ObterIdSelecionado();
               return repoFesta.SelecionarPorId(id);
          }
          public override void Editar()
          {
               Festa festaSelecionado = ObterFestaSelecionado();

               if (festaSelecionado == null)
               {
                    MessageBox.Show($"Selecione uma festa primeiro!",
                        "Edição de Festas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
               }
               List<Cliente> clientes = repositorioCliente.SelecionarTodos();
               List<Tema> temas = repositorioTema.SelecionarTodos();

               TelaFestaForm telaFesta = new TelaFestaForm(clientes, temas);
               telaFesta.Text = "Edição de Festas";
               telaFesta.ConfigurarTela(festaSelecionado);
               telaFesta.PegarListaNome(repoFesta.SelecionarTodos());
               DialogResult opcaoEscolhida = telaFesta.ShowDialog();

               if (opcaoEscolhida == DialogResult.OK)
               {
                    Festa festa = telaFesta.ObterFesta();
                    repoFesta.Editar(festa.id, festa);
               }

               CarregarFestas();

               if (opcaoEscolhida == DialogResult.OK)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Festa editada com sucesso!", TipoStatusEnum.Sucesso);

          }

          public override void Inserir()
          {
               List<Cliente> clientes = repositorioCliente.SelecionarTodos();
               List<Tema> temas = repositorioTema.SelecionarTodos();

               TelaFestaForm telaFesta = new TelaFestaForm(clientes, temas);
               telaFesta.PegarListaNome(repoFesta.SelecionarTodos());
               DialogResult opcaoEscolhida = telaFesta.ShowDialog();

               if (opcaoEscolhida == DialogResult.OK)
               {
                    Festa novaFesta = telaFesta.ObterFesta();
                    repoFesta.Inserir(novaFesta);
               
               }

               CarregarFestas();

               if (opcaoEscolhida == DialogResult.OK)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Festas inserida com sucesso!", TipoStatusEnum.Sucesso);


          }
          private void CarregarFestas()
          {
               List<Festa> festas = repoFesta.SelecionarTodos();
               tabelaFesta.AtualizarRegistros(festas);
               TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {festas.Count} festa(s)", TipoStatusEnum.Visualizando);
          }

          public override UserControl ObterListagem()
          {
               if (tabelaFesta == null)
                    tabelaFesta = new TabelaFestaControl();

               CarregarFestas();

               return tabelaFesta;
          }

          public override string ObterTipoCadastro()
          {
               return "Cadastro de Festas";
          }
     }
}
