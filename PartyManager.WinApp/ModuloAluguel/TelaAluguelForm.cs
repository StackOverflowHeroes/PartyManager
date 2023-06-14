using PartyManager.Dominio.ModuloAluguel;
using PartyManager.Dominio.ModuloCliente;
using PartyManager.Dominio.ModuloFesta;

namespace PartyManager.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        public TelaAluguelForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public Aluguel ObterAluguel()
        {
            int id = Convert.ToInt32(tboxId.Text);
            Festa festa = comboBoxFesta.SelectedItem as Festa;
            DateTime dataAbertura = dateAbertura.Value.Date;
            DateTime dataFechamento = dateFechamento.Value.Date;
            StatusPagamentoEnum status = (StatusPagamentoEnum)comboBoxPagamento.SelectedItem;

            Aluguel aluguel = new Aluguel(id, festa/*, cliente*/, dataAbertura, dataFechamento, status);

            if (id > 0)
                aluguel.id = id;

            return aluguel;
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
            //listaCompletaCliente.ForEach(cliente => comboBoxCliente.Items.Add(cliente));
        }

        public void ConfigurarTela(Aluguel aluguelSelecionado)
        {
            comboBoxFesta.SelectedItem = aluguelSelecionado.festa;
            //comboBoxCliente.SelectedItem = aluguelSelecionado.cliente;
            comboBoxPagamento.SelectedItem = aluguelSelecionado.statusPagamento;
            dateAbertura.Value = aluguelSelecionado.dataAbertura;
            dateFechamento.Value = aluguelSelecionado.dataFechamento;
        }

        private void comboBoxFesta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Festa festaSelecionada = (Festa)comboBoxFesta.SelectedItem;
            txtCliente.Text = festaSelecionada.cliente.nome;
        }
    }
}
