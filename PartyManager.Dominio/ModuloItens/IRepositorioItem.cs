
using PartyManager.Dominio.ModuloTema;

namespace PartyManager.Dominio.ModuloItens
{
    public interface IRepositorioItem : IRepositorioBase<Item>
    {
        bool VerificarSeRegistroEstaSendoUsado(Item itemSelecionado, List<Tema> temas);
    }
}
