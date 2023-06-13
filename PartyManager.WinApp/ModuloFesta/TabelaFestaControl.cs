using PartyManager.Dominio.ModuloCliente;
using PartyManager.Dominio.ModuloFesta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                tabelaFestas.Rows.Add(festa.id, festa.cliente.nome,festa.data, festa.tema.nome);
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

