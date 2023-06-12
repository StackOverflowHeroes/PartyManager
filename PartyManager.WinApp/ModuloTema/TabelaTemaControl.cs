using PartyManager.Dominio.ModuloTema;

namespace PartyManager.WinApp.ModuloTema
{
    public partial class TabelaTemaControl : UserControl
    {
        public TabelaTemaControl()
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
                         HeaderText = "Nome"
                    },

                    new DataGridViewTextBoxColumn()
                    {
                         Name = "valorTotalItens",
                         HeaderText = "Valor total dos itens"
                    }
            };

            tabelaTemas.Columns.AddRange(gridCliente);
        }

        public void AtualizarRegistros(List<Tema> temas)
        {
            tabelaTemas.Rows.Clear();

            foreach (Tema tema in temas)
            {
                tabelaTemas.Rows.Add(tema.id, tema.nome.ToUpper(), $"R$  {tema.valorTotalItens}");
            }
        }

        public int ObterIdSelecionado()
        {
            if (tabelaTemas.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(tabelaTemas.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}
