using PartyManager.Dominio.ModuloFesta;

namespace PartyManager.WinApp.ModuloFesta
{
    public partial class TabelaFestaControl : UserControl
    {
        public TabelaFestaControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            tabelaFestas.ConfigurarGridSomenteLeitura();
            tabelaFestas.ConfigurarGridZebrado();
        }
        private void ConfigurarColunas()
        {
            DataGridViewColumn[] gridFesta = new DataGridViewColumn[]
            {
                    new DataGridViewTextBoxColumn()
                    {
                         Name = "id",
                         HeaderText = "Nº"
                    },
                    
                    new DataGridViewTextBoxColumn()
                    {
                         Name = "Nome",
                         HeaderText = "Nome"
                    },
                    new DataGridViewTextBoxColumn()
                    {
                         Name = "Cliente",
                         HeaderText = "Cliente"
                    },

                    new DataGridViewTextBoxColumn()
                    {
                         Name = "Data",
                         HeaderText = "Data"
                    },
                    new DataGridViewTextBoxColumn()
                    {
                         Name = "Tema",
                         HeaderText = "Tema"
                    }
            };

            tabelaFestas.Columns.AddRange(gridFesta);
        }
        public void AtualizarRegistros(List<Festa> festas)
        {
            tabelaFestas.Rows.Clear();

            foreach (Festa festa in festas)
            {
                tabelaFestas.Rows.Add(festa.id, 
                    festa.nome,
                    festa.cliente.nome,
                    festa.data.ToShortDateString(), 
                    festa.tema.nome.ToUpper());
            }
        }
        public int ObterIdSelecionado()
        {
            if (tabelaFestas.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(tabelaFestas.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}

