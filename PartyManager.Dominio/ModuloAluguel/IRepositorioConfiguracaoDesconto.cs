
namespace PartyManager.Dominio.ModuloAluguel
{
    public interface IRepositorioConfiguracaoDesconto
    {
        void GravarConfiguracoesDesconto(ConfiguracaoDesconto configuracaoDesconto);
        ConfiguracaoDesconto ObterConfiguracaoDeDesconto();
    }
}
