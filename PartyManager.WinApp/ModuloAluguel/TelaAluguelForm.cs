using PartyManager.Dominio.ModuloAluguel;
using PartyManager.Dominio.ModuloCliente;
using PartyManager.Dominio.ModuloFesta;

namespace PartyManager.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        private ConfiguracaoDesconto desconto;
        public TelaAluguelForm(ConfiguracaoDesconto desconto)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            this.desconto = desconto;
        }

        public Aluguel ObterAluguel()
        {
            int id = Convert.ToInt32(tboxId.Text);
            Festa festa = comboBoxFesta.SelectedItem as Festa;
            decimal valorTotal = CalcularValorTotal(festa.tema.valorTotalItens, festa.cliente);
            decimal valorEntrada = CalcularValorEntrada(valorTotal);
            DateTime dataAbertura = dateAbertura.Value.Date;
            DateTime dataFechamento = dateFechamento.Value.Date;
            StatusPagamentoEnum status = (StatusPagamentoEnum)comboBoxPagamento.SelectedItem;

            Aluguel aluguel = new Aluguel(id, festa, valorEntrada, valorTotal, dataAbertura, dataFechamento, status);

            if (id > 0)
                aluguel.id = id;

            return aluguel;
        }

        public Festa ObterFesta()
        {
            Festa festa = comboBoxFesta.SelectedItem as Festa;                       

            return festa;
        }

        private decimal CalcularValorTotal(decimal valorTotalItens, Cliente cliente)
        {
            decimal valorDescontoCliente = desconto.PorcentagemDesconto * cliente.alugueis.Count;
            decimal valorParaSerDescontado;

            if (cliente.alugueis.Count() == 0)
                return valorTotalItens;

            if (valorDescontoCliente >= desconto.PorcentagemMaxima)
                valorParaSerDescontado = desconto.PorcentagemMaxima / 100;
            else
                valorParaSerDescontado = valorDescontoCliente / 100;

            decimal descontoSobreTotal =  valorTotalItens * valorParaSerDescontado;
            return valorTotalItens - descontoSobreTotal;

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Aluguel aluguel = ObterAluguel();

            string[] erros = aluguel.ValidarErros();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0], TipoStatusEnum.Erro);
                DialogResult = DialogResult.None;
            }

        }

        public void PopularComboBox(List<Cliente> listaCompletaCliente, List<Festa> listaCompletaFesta)
        {
            List<StatusPagamentoEnum> statusPagamento = Enum.GetValues<StatusPagamentoEnum>().ToList();
            statusPagamento.ForEach(status => comboBoxPagamento.Items.Add(status));
            comboBoxPagamento.SelectedIndex = 0;

            listaCompletaFesta.ForEach(festa => comboBoxFesta.Items.Add(festa));
        }

        public void ConfigurarTela(Aluguel aluguelSelecionado)
        {
            comboBoxFesta.SelectedItem = aluguelSelecionado.festa;
            comboBoxPagamento.SelectedItem = aluguelSelecionado.statusPagamento;
            TextBoxValorEntrada.Text = aluguelSelecionado.valor.ToString();
            dateAbertura.Value = aluguelSelecionado.dataAbertura;
            dateFechamento.Value = aluguelSelecionado.dataFechamento;
        }

        private void comboBoxFesta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Festa festaSelecionada = (Festa)comboBoxFesta.SelectedItem;
            txtCliente.Text = festaSelecionada.cliente.nome;
        }

        private void comboBoxPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Festa festa = ObterFesta();

            if (comboBoxPagamento.SelectedItem.ToString() == StatusPagamentoEnum.PagamentoParcial.ToString())
            {
                TextBoxValorEntrada.Enabled = true;
                InputPorcentagem.Enabled = true;
                InputPorcentagem.Value = 40;
                CalcularValorEntrada(CalcularValorTotal(festa.tema.valorTotalItens, festa.cliente));
            }
            else if (comboBoxPagamento.SelectedItem.ToString() == StatusPagamentoEnum.PagamentoConcluido.ToString()) 
            {
                TextBoxValorEntrada.Enabled = true;
                InputPorcentagem.Value = 100;
                InputPorcentagem.Enabled = false;
                TextBoxValorEntrada.Enabled = false;
            }

            else
                TextBoxValorEntrada.Enabled = false;

        }

        private decimal CalcularValorEntrada(decimal valorPagar)
        {
            decimal valorTotal = valorPagar;
            decimal porcentagem = InputPorcentagem.Value / 100;
            decimal resultadoValor = (valorTotal * porcentagem);

            TextBoxValorEntrada.Text = resultadoValor.ToString();

            return resultadoValor;
        }

        private void InputPorcentagem_ValueChanged(object sender, EventArgs e)
        {
            Festa festa = ObterFesta();

            CalcularValorEntrada(CalcularValorTotal(festa.tema.valorTotalItens, festa.cliente));
        }
    }
}
