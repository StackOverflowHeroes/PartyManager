using PartyManager.Dominio.ModuloTema;

namespace PartyManager.Dados.Arquivo.ModuloTema
{
    public class RepositorioTemaArquivo : RepositorioArquivoBase<Tema>, IRepositorioTema
    {
        public RepositorioTemaArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Tema> ObterRegistros()
        {
           return contextoDados.temas;
        }
    }
}
