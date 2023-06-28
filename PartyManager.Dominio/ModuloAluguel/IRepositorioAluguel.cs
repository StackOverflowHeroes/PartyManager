namespace PartyManager.Dominio.ModuloAluguel
{
    public interface IRepositorioAluguel : IRepositorioBase<Aluguel>
    {
        List<Aluguel> SelecionarAlugueisConcluidos();
        List<Aluguel> SelecionarAlugueisPendentes();
        bool ExistePagamentoPendente();
    }
}
