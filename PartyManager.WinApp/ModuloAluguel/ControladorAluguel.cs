﻿using PartyManager.Dominio.ModuloAluguel;
using PartyManager.Dominio.ModuloCliente;
using PartyManager.Dominio.ModuloFesta;

namespace PartyManager.WinApp.ModuloAluguel
{
     public class ControladorAluguel : ControladorBase
     {
          private IRepositorioAluguel repoAluguel;
          private IRepositorioFesta repoFesta;
          private IRepositorioCliente repoCliente;
          private TabelaAluguelControl tabelaAluguel;

          public ControladorAluguel(IRepositorioAluguel repositorioAluguel, IRepositorioFesta repositorioFesta, IRepositorioCliente repositorioCliente)
          {
               repoAluguel = repositorioAluguel;
               repoFesta = repositorioFesta;
               repoCliente = repositorioCliente;
          }

          public override string ToolTipInserir => "Inserir Aluguel";

          public override string ToolTipEditar => "Editar Aluguel";

          public override string ToolTipDeletar => "Deletar Aluguel";

          public override void Deletar()
          {
               Aluguel aluguelSelecionado = ObterAluguelSelecionado();

               if (aluguelSelecionado == null)
               {
                    MessageBox.Show($"Selecione um aluguel primeiro!",
                        "Exclusão de Aluguéis",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    return;
               }

               DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o aluguel do cliente {aluguelSelecionado.festa.cliente.nome}?", "Exclusão de Aluguéis",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

               if (opcaoEscolhida == DialogResult.OK)
                    repoAluguel.Deletar(aluguelSelecionado);

               CarregarAlugueis();

               if (opcaoEscolhida == DialogResult.OK)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Tema deletado com sucesso!", TipoStatusEnum.Sucesso);
          }

          public override void Editar()
          {
               TelaAluguelForm telaAluguel = new TelaAluguelForm();
               Aluguel aluguelSelecionado = ObterAluguelSelecionado();

               if (aluguelSelecionado == null)
               {
                    MessageBox.Show($"Selecione um aluguel primeiro!",
                        "Edição de Aluguéis",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
               }

               List<Cliente> ListaCompletaCliente = repoCliente.SelecionarTodos();
               List<Festa> ListaCompletaFesta = repoFesta.SelecionarTodos();
               telaAluguel.PopularComboBox(ListaCompletaCliente, ListaCompletaFesta);
               telaAluguel.Text = "Edição de Aluguéis";
               telaAluguel.ConfigurarTela(aluguelSelecionado);

               DialogResult opcaoEscolhida = telaAluguel.ShowDialog();
               if (opcaoEscolhida == DialogResult.OK)
               {
                    Aluguel aluguelAtualizado = telaAluguel.ObterAluguel();
                    aluguelAtualizado.CalcularValorPagamento();
                    repoAluguel.Editar(aluguelSelecionado.id, aluguelAtualizado);

               }

               CarregarAlugueis();

               if (opcaoEscolhida == DialogResult.OK)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Aluguel editado com sucesso!", TipoStatusEnum.Sucesso);
          }

          public override void Inserir()
          {
               List<Cliente> ListaCompletaCliente = repoCliente.SelecionarTodos();
               List<Festa> ListaCompletaFesta = repoFesta.SelecionarTodos();

               TelaAluguelForm telaAluguel = new TelaAluguelForm();
               telaAluguel.PopularComboBox(ListaCompletaCliente, ListaCompletaFesta);

               DialogResult opcaoEscolhida = telaAluguel.ShowDialog();
               if (opcaoEscolhida == DialogResult.OK)
               {
                    Aluguel aluguel = telaAluguel.ObterAluguel();
                    aluguel.CalcularValorPagamento();
                    repoAluguel.Inserir(aluguel);
               }

               CarregarAlugueis();

               if (opcaoEscolhida == DialogResult.OK)
                    TelaPrincipalForm.Instancia.AtualizarRodape($"Aluguel inserido com sucesso!", TipoStatusEnum.Sucesso);
          }

          private Aluguel ObterAluguelSelecionado()
          {
               int id = tabelaAluguel.ObterIdSelecionado();
               return repoAluguel.SelecionarPorId(id);
          }

          public void CarregarAlugueis()
          {
               List<Aluguel> alugueis = repoAluguel.SelecionarTodos();
               tabelaAluguel.AtualizarRegistros(alugueis);
               TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {alugueis.Count} aluguel/alguéis", TipoStatusEnum.Visualizando);
          }

          public override UserControl ObterListagem()
          {
               if (tabelaAluguel == null)
                    tabelaAluguel = new TabelaAluguelControl();

               CarregarAlugueis();

               return tabelaAluguel;
          }

          public override string ObterTipoCadastro()
          {
               return "Cadastros de Aluguéis";
          }
     }
}
