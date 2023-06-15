
using PartyManager.Dominio.ModuloItens;
using PartyManager.Dominio.ModuloTema;
using PartyManager.WinApp.ModuloTema;

namespace PartyManager.WinApp.ModuloItens
{
    public class ControladorItens : ControladorBase
    {
        private IRepositorioItem repoItem;
        private TabelaItensControl tabelaItens;

        public ControladorItens(IRepositorioItem repositorioItem)
        {
            this.repoItem = repositorioItem;
        }

        public override string ToolTipInserir => throw new NotImplementedException();

        public override string ToolTipEditar => throw new NotImplementedException();

        public override string ToolTipDeletar => throw new NotImplementedException();

        public override void Deletar()
        {
            throw new NotImplementedException();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            throw new NotImplementedException();
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
