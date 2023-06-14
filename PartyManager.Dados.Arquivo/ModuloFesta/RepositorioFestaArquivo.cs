using PartyManager.Dominio.ModuloFesta;

namespace PartyManager.Dados.Arquivo.ModuloFesta
{
    public class RepositorioFestaArquivo : RepositorioArquivoBase<Festa>, IRepositorioFesta
    {
        public RepositorioFestaArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Festa> ObterRegistros()
        {
            return contextoDados.festas;
        }
    }
}
