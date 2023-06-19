using PartyManager.Dominio.ModuloAluguel;

namespace PartyManager.Dados.Arquivo.ModuloAluguel
{
    public class RepositorioAluguelArquivo : RepositorioArquivoBase<Aluguel>, IRepositorioAluguel
    {
        public RepositorioAluguelArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        public List<Aluguel> SelecionarAlugueisConcluidos()
        {
            List<Aluguel> ListaCompleta = SelecionarTodos();
            return ListaCompleta.Where(x => x.statusPagamento == StatusPagamentoEnum.PagamentoConcluido).ToList();
        }

        public List<Aluguel> SelecionarAlugueisPendentes()
        {
            List<Aluguel> ListaFiltrada = new List<Aluguel>();
            ListaFiltrada = SelecionarTodos().Where(x => x.statusPagamento == StatusPagamentoEnum.PagamentoParcial).ToList();
            ListaFiltrada.AddRange(SelecionarTodos().Where(x => x.statusPagamento == StatusPagamentoEnum.Pendente).ToList());

            return ListaFiltrada;
        }

        protected override List<Aluguel> ObterRegistros()
        {
            return contextoDados.alugueis;
        }
    }
}
