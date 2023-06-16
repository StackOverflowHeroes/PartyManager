﻿using PartyManager.Dominio.ModuloAluguel;
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
            decimal valor = Convert.ToDecimal(TextBoxValorEntrada.Text);
            DateTime dataAbertura = dateAbertura.Value.Date;
            DateTime dataFechamento = dateFechamento.Value.Date;
            StatusPagamentoEnum status = (StatusPagamentoEnum)comboBoxPagamento.SelectedItem;

            Aluguel aluguel = new Aluguel(id, festa, valor, dataAbertura, dataFechamento, status);

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
            if (comboBoxPagamento.SelectedItem.ToString() == StatusPagamentoEnum.PagamentoParcial.ToString())
            {
                TextBoxValorEntrada.Enabled = true;
                InputPorcentagem.Value = 40;
                CalcularValorEntrada();
            }
            else if (comboBoxPagamento.SelectedItem.ToString() == StatusPagamentoEnum.PagamentoConcluido.ToString()) 
            {
                TextBoxValorEntrada.Enabled = true;
                InputPorcentagem.Value = 100;
            }

            else
                TextBoxValorEntrada.Enabled = false;

        }

        private void CalcularValorEntrada()
        {
            Festa festa = (Festa)comboBoxFesta.SelectedItem;

            if (festa == null)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("O campo festa é obrigatório para o cadastro da entrada", TipoStatusEnum.Erro);

                DialogResult = DialogResult.None;
                return;
            }

            decimal porcentagem = InputPorcentagem.Value / 100;
            TextBoxValorEntrada.Text = (festa.tema.valorTotalItens * porcentagem).ToString();
        }

        private void InputPorcentagem_ValueChanged(object sender, EventArgs e)
        {
            CalcularValorEntrada();
        }
    }
}
