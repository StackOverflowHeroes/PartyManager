using PartyManager.Dominio.ModuloAluguel;
using PartyManager.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyManager.WinApp.ModuloCliente
{
     public partial class TelaHistoricoClienteForm : Form
     {
          public TelaHistoricoClienteForm(Cliente cliente)
          {
               InitializeComponent();
               this.ConfigurarDialog();
               ConfigurarGrid();
               CarregarAlugueisCliente(cliente);
          }

          private void CarregarAlugueisCliente(Cliente cliente)
          {
               gridAlugueisCliente.Rows.Clear();

               foreach (Aluguel aluguel in cliente.alugueis)
               {
                    gridAlugueisCliente.Rows.Add(aluguel.id, aluguel.valor, aluguel.statusPagamento, aluguel.dataAbertura.ToShortDateString(), aluguel.dataFechamento.ToShortDateString());
               }
          }

          private void ConfigurarGrid()
          {
               DataGridViewColumn[] gridAluguelCliente = new DataGridViewColumn[]
{
                    new DataGridViewTextBoxColumn()
                    {
                         Name = "id",
                         HeaderText = "Nº",
                         Width = 50
                    },

                    new DataGridViewTextBoxColumn()
                    {
                         Name = "valor",
                         HeaderText = "Valor",
                         Width = 50
                    },

                    new DataGridViewTextBoxColumn()
                    {
                         Name = "statusPagamento",
                         HeaderText = "Status Pagamento",
                         MinimumWidth = 200
                    },

                    new DataGridViewTextBoxColumn()
                    {
                         Name = "dataAbertura",
                         HeaderText = "Abertura",
                    },

                    new DataGridViewTextBoxColumn()
                    {
                         Name = "dataFechamento",
                         HeaderText = "Fechamento",
                    }
};

               gridAlugueisCliente.Columns.AddRange(gridAluguelCliente);
          }
     }
}
