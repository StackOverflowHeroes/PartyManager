using PartyManager.Dominio.ModuloAluguel;
using PartyManager.Dominio.ModuloTema;

namespace PartyManager.Dados.Arquivo.ModuloTema
{
    public class RepositorioTemaArquivo : RepositorioArquivoBase<Tema>, IRepositorioTema
    {
        public RepositorioTemaArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        public bool VerificarSeRegistroEstaSendoUsado(Tema temaSelecionado, List<Aluguel> ListaCompletaAluguel)
        {
            bool RegistroExiste = ListaCompletaAluguel.Exists(aluguel => aluguel.festa.tema.nome == temaSelecionado.nome);

            if (RegistroExiste)
                return true;
            else
                return false;
        }

        protected override List<Tema> ObterRegistros()
        {
           return contextoDados.temas;
        }
    }
}
