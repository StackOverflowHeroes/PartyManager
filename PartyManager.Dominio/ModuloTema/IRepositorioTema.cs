using PartyManager.Dominio.ModuloAluguel;

namespace PartyManager.Dominio.ModuloTema
{
    public interface IRepositorioTema : IRepositorioBase<Tema>
    {
        bool VerificarSeRegistroEstaSendoUsado(Tema temaSelecionado, List<Aluguel> ListaAluguel);
    }
}
