using PartyManager.Dominio.ModuloAluguel;

namespace PartyManager.Dados.Arquivo.ModuloAluguel
{
    public class RepositorioAluguelArquivo : RepositorioArquivoBase<Aluguel>, IRepositorioAluguel
    {
        public RepositorioAluguelArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Aluguel> ObterRegistros()
        {
            return contextoDados.alugueis;
        }
    }
}
