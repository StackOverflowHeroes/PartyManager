
using PartyManager.Dominio.ModuloItens;
using PartyManager.Dominio.ModuloTema;

namespace PartyManager.WinApp.ModuloItens
{
    public partial class TabelaItensControl : UserControl
    {
        public TabelaItensControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            tabelaTemas.ConfigurarGridSomenteLeitura();
            tabelaTemas.ConfigurarGridZebrado();
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
                         HeaderText = "Descrição"
                    },

                    new DataGridViewTextBoxColumn()
                    {
                         Name = "valor",
                         HeaderText = "Valor"
                    }
            };

            tabelaItens.Columns.AddRange(gridCliente);
        }

        public void AtualizarRegistros(List<Item> itens)
        {
            tabelaItens.Rows.Clear();

            foreach (Item registro in itens)
            {
                tabelaItens.Rows.Add(registro.id, registro.nome.ToUpper(), $"R$  {registro.valor}");
            }
        }

        public int ObterIdSelecionado()
        {
            if (tabelaItens.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(tabelaItens.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}
