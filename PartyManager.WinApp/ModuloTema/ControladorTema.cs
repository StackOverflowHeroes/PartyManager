using PartyManager.Dominio.ModuloAluguel;
using PartyManager.Dominio.ModuloCliente;
using PartyManager.Dominio.ModuloItens;
using PartyManager.Dominio.ModuloTema;

namespace PartyManager.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        private IRepositorioTema repoTema;
        private IRepositorioItem repoItem;
        private IRepositorioAluguel repoAluguel;
        private TabelaTemaControl tabelaTema;

        public ControladorTema(IRepositorioTema repoTema, IRepositorioItem repoItem, IRepositorioAluguel repoAluguel)
        {
            this.repoTema = repoTema;
            this.repoItem = repoItem;
            this.repoAluguel = repoAluguel;
        }

        public override string ToolTipInserir => "Inserir Tema";

        public override string ToolTipEditar => "Editar Tema";

        public override string ToolTipDeletar => "Deletar Tema";

        public override void Deletar()
        {
            Tema temaSelecionado = ObterTemaSelecionado();

            if (temaSelecionado == null)
            {
                MessageBox.Show($"Selecione um tema primeiro!",
                    "Exclusão de Temas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            if(repoTema.VerificarSeRegistroEstaSendoUsado(temaSelecionado, repoAluguel.SelecionarTodos()))
            {
                MessageBox.Show($"Não é possível excluir um tema em uso",
                    "Exclusão de Temas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o tema {temaSelecionado.nome.ToUpper()}?", "Exclusão de Temas",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repoTema.Deletar(temaSelecionado);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Tema deletado com sucesso!", TipoStatusEnum.Sucesso);
            }

            CarregarTemas();
        }

        public override void Editar()
        {
            TelaTemaForm telaTema = new TelaTemaForm();
            telaTema.PegarListaNome(repoTema.SelecionarTodos());
            Tema temaSelecionado = ObterTemaSelecionado();

            if (temaSelecionado == null)
            {
                MessageBox.Show($"Selecione um tema primeiro!",
                    "Edição de Temas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            telaTema.Text = "Edição de Temas";
            telaTema.ConfigurarTela(temaSelecionado, repoItem.SelecionarTodos());

            DialogResult opcaoEscolhida = telaTema.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema temaAtualizado = telaTema.ObterTema();
                temaAtualizado.CalcularPrecoTotal();
                repoTema.Editar(temaAtualizado.id, temaAtualizado);
            }

            CarregarTemas();

            if (opcaoEscolhida == DialogResult.OK)
                TelaPrincipalForm.Instancia.AtualizarRodape($"Tema editado com sucesso!", TipoStatusEnum.Sucesso);

        }

        public override void Inserir()
        {
            TelaTemaForm telaTema = new TelaTemaForm();
            telaTema.PegarListaNome(repoTema.SelecionarTodos());
            telaTema.PopularCheckedListBox(repoItem.SelecionarTodos());
            DialogResult opcaoEscolhida = telaTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema novoTema = telaTema.ObterTema();
                novoTema.CalcularPrecoTotal();
                repoTema.Inserir(novoTema);
            }

            CarregarTemas();

            if (opcaoEscolhida == DialogResult.OK)
                TelaPrincipalForm.Instancia.AtualizarRodape($"Tema inserido com sucesso!", TipoStatusEnum.Sucesso);
        }

        private Tema ObterTemaSelecionado()
        {
            int id = tabelaTema.ObterIdSelecionado();
            return repoTema.SelecionarPorId(id);
        }

        private void CarregarTemas()
        {
            List<Tema> temas = repoTema.SelecionarTodos();
            tabelaTema.AtualizarRegistros(temas);
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {temas.Count} tema(s)", TipoStatusEnum.Visualizando);
        }
        public override UserControl ObterListagem()
        {
            if (tabelaTema == null)
                tabelaTema = new TabelaTemaControl();

            CarregarTemas();

            return tabelaTema;
        }
        public override string ObterTipoCadastro()
        {
            return "Cadastros de Temas";

        }
    }
}
