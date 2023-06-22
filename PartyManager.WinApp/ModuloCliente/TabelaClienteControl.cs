using PartyManager.Dominio.ModuloCliente;

namespace PartyManager.WinApp.ModuloCliente
{
     public partial class TabelaClienteControl : UserControl
     {
          public TabelaClienteControl()
          {
               InitializeComponent();
               ConfigurarColunas();
               tabelaCliente.ConfigurarGridSomenteLeitura();
               tabelaCliente.ConfigurarGridZebrado();
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
                         Name = "nome",
                         HeaderText = "Nome"
                    },

                    new DataGridViewTextBoxColumn()
                    {
                         Name = "telefone",
                         HeaderText = "Telefone"
                    },

                    new DataGridViewTextBoxColumn()
                    {
                         Name = "alugueis",
                         HeaderText = "Qtd. Aluguéis Realizados"
                    }
               };

               tabelaCliente.Columns.AddRange(gridCliente);
          }

          public void AtualizarRegistros(List<Cliente> clientes)
          {
               tabelaCliente.Rows.Clear();

               foreach (Cliente cliente in clientes)
               {
                    tabelaCliente.Rows.Add(cliente.id, cliente.nome, cliente.telefone, cliente.alugueis.Count);
               }
          }

          public int ObterIdSelecionado()
          {
               if (tabelaCliente.SelectedRows.Count == 0)
                    return -1;

               int id = Convert.ToInt32(tabelaCliente.SelectedRows[0].Cells["id"].Value);

               return id;
          }
     }
}
