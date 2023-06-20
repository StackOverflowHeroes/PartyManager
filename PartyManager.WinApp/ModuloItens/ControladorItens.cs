
using PartyManager.Dominio.ModuloItens;
using PartyManager.Dominio.ModuloTema;
using PartyManager.WinApp.ModuloTema;

namespace PartyManager.WinApp.ModuloItens
{
    public class ControladorItens : ControladorBase
    {
        private IRepositorioItem repoItem;
        private IRepositorioTema repoTema;
        private TabelaItensControl tabelaItens;

        public ControladorItens(IRepositorioItem repositorioItem, IRepositorioTema repoTema)
        {
            this.repoItem = repositorioItem;
            this.repoTema = repoTema;
        }

        public override string ToolTipInserir => "Inserir item";

        public override string ToolTipEditar => "Editar Item";

        public override string ToolTipDeletar => "Deletar Item";

        public override void Deletar()
        {
            Item itemSelecionado = ObterItemSelecionado();

            if (itemSelecionado == null)
            {
                MessageBox.Show($"Selecione um item primeiro!",
                    "Exclusão de Itens",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            if (repoItem.VerificarSeRegistroEstaSendoUsado(itemSelecionado, repoTema.SelecionarTodos()))
            {
                MessageBox.Show($"Não é possível excluir um item em uso",
                    "Exclusão de Itens",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o item {itemSelecionado.nome.ToUpper()}?", "Exclusão de Itens",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repoItem.Deletar(itemSelecionado);
            }

            CarregarItens();

            if (opcaoEscolhida == DialogResult.OK)
                TelaPrincipalForm.Instancia.AtualizarRodape($"Tema deletado com sucesso!", TipoStatusEnum.Sucesso);
        }

        public override void Editar()
        {
            TelaItensForm telaItens = new TelaItensForm();
            Item itemSelecionado = ObterItemSelecionado();

            if (itemSelecionado == null)
            {
                MessageBox.Show($"Selecione um item primeiro!",
                    "Edição de Itens",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            telaItens.Text = "Edição de Temas";
            telaItens.ConfigurarTela(itemSelecionado);

            DialogResult opcaoEscolhida = telaItens.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                Item itemAtualizado = telaItens.ObterItem();
                repoItem.Editar(itemAtualizado.id, itemAtualizado);
            }

            CarregarItens();

            if (opcaoEscolhida == DialogResult.OK)
                TelaPrincipalForm.Instancia.AtualizarRodape($"Tema editado com sucesso!", TipoStatusEnum.Sucesso);
        }

        public override void Inserir()
        {
            TelaItensForm telaItens = new TelaItensForm();
            telaItens.PegarListaNome(repoItem.SelecionarTodos());

            if (telaItens.ShowDialog() == DialogResult.OK)
            {
                Item novoItem = telaItens.ObterItem();
                repoItem.Inserir(novoItem);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Item inserido com sucesso!", TipoStatusEnum.Sucesso);
            }

            CarregarItens();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaItens == null)
                tabelaItens = new TabelaItensControl();

            CarregarItens();

            return tabelaItens;
        }

        private void CarregarItens()
        {
            List<Item> itens = repoItem.SelecionarTodos();
            tabelaItens.AtualizarRegistros(itens);
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {itens.Count} item(s)", TipoStatusEnum.Visualizando);
        }

        private Item ObterItemSelecionado()
        {
            int id = tabelaItens.ObterIdSelecionado();
            return repoItem.SelecionarPorId(id);
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastros de Itens";
        }
    }
}
