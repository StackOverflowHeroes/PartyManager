
using PartyManager.Dominio.ModuloItens;
using PartyManager.Dominio.ModuloTema;

namespace PartyManager.Dados.Arquivo.ModuloItens
{
    public class RepositorioItensArquivo : RepositorioArquivoBase<Item>, IRepositorioItem
    {
        public RepositorioItensArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        public bool VerificarSeRegistroEstaSendoUsado(Item itemSelecionado, List<Tema> temas)
        {
            bool RegistroExiste = temas.Exists(tema => tema.ListaItens.Exists(item => item.nome == itemSelecionado.nome));

            if (RegistroExiste)
                return true;
            else
                return false;
        }

        protected override List<Item> ObterRegistros()
        {
            return contextoDados.itens;
        }
    }
}
