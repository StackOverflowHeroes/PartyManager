
using PartyManager.Dominio.ModuloAluguel;

namespace PartyManager.WinApp.ModuloAluguel
{
    public partial class TabelaAluguelControl : UserControl
    {
        public TabelaAluguelControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            tabelaAluguel.ConfigurarGridSomenteLeitura();
            tabelaAluguel.ConfigurarGridZebrado();
        }
        private void ConfigurarColunas()
        {
            DataGridViewColumn[] gridCliente = new DataGridViewColumn[]
            {
                    new DataGridViewTextBoxColumn()
                    {
                         Name = "id",
                         HeaderText = "Nº"
                    },

                    new DataGridViewTextBoxColumn()
                    {
                         Name = "data",
                         HeaderText = "Data da festa"
                    },
                    new DataGridViewTextBoxColumn()
                    {
                         Name = "cliente",
                         HeaderText = "Cliente"
                    },
                    new DataGridViewTextBoxColumn()
                    {
                         Name = "valorTotal",
                         HeaderText = "Valor (R$)"
                    },
                    new DataGridViewTextBoxColumn()
                    {
                         Name = "dataAbertura",
                         HeaderText = "Data de Abertura"
                    },
                    new DataGridViewTextBoxColumn()
                    {
                         Name = "dataFechamento",
                         HeaderText = "Data de Fechamento"
                    },
                    new DataGridViewTextBoxColumn()
                    {
                         Name = "pagamento",
                         HeaderText = "Pagamento"
                    }
            };

            tabelaAluguel.Columns.AddRange(gridCliente);
        }
        public void AtualizarRegistros(List<Aluguel> alugueis)
        {
            tabelaAluguel.Rows.Clear();

            foreach (Aluguel registro in alugueis)
            {
                tabelaAluguel.Rows.Add(
                    registro.id, 
                    registro.festa.data.ToShortDateString(), 
                    registro.festa.cliente.nome, 
                    registro.valor,
                    registro.dataAbertura.ToShortDateString(), 
                    registro.dataFechamento.ToShortDateString(), 
                    registro.statusPagamento);
            }
        }

        public int ObterIdSelecionado()
        {
            if (tabelaAluguel.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(tabelaAluguel.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}
