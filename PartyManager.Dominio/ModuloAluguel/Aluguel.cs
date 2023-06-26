using PartyManager.Dominio.ModuloFesta;

namespace PartyManager.Dominio.ModuloAluguel
{
    public class Aluguel : EntidadeBase<Aluguel>
    {
        public Festa festa;
        public decimal valor;
        public decimal valorTotal;
        public StatusPagamentoEnum statusPagamento;
        public DateTime dataAbertura;
        public DateTime dataFechamento;

        public Aluguel()
        {
        }

        public Aluguel(int id, Festa festa, decimal valor, decimal valorTotal, DateTime dataAbertura, DateTime dataFechamento, StatusPagamentoEnum statusPagamento = StatusPagamentoEnum.Pendente)
        {
            this.id = id;
            this.festa = festa;
            this.valor = valor;
            this.valorTotal = valorTotal;
            this.statusPagamento = statusPagamento;
            this.dataAbertura = dataAbertura;
            this.dataFechamento = dataFechamento;
        }

        public override void AtualizarRegistros(Aluguel registroAtualizado)
        {
            festa = registroAtualizado.festa;
            valor = registroAtualizado.valor;
            valorTotal = registroAtualizado.valorTotal;
            statusPagamento = registroAtualizado.statusPagamento;
            dataAbertura = registroAtualizado.dataAbertura;
            dataFechamento = registroAtualizado.dataFechamento;
        }


        public override string[] ValidarErros()
        {
            List<string> ErrosAluguel = new List<string>();

            if (festa == null)
                ErrosAluguel.Add("É obrigatório atribuir uma festa");

            if (dataAbertura < DateTime.Today)
                ErrosAluguel.Add("Não é possível cadastrar um aluguel no passado");
            if (dataFechamento < dataAbertura)
                ErrosAluguel.Add("A data de fechamento não pode ser anterior a de abertura");

            return ErrosAluguel.ToArray();
        }
    }
}
