
using PartyManager.Dominio.ModuloItens;

namespace PartyManager.Dados.Arquivo.ModuloItens
{
    public class RepositorioItensArquivo : RepositorioArquivoBase<Item>, IRepositorioItem
    {
        public RepositorioItensArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Item> ObterRegistros()
        {
            return contextoDados.itens;
        }
    }
}
