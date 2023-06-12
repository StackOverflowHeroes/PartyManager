
using System.Drawing;
using PartyManager.Dominio.ModuloTema;

namespace PartyManager.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        List<Item> ListaItensTema = new List<Item>();

        public TelaTemaForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public Tema ObterTema()
        {
            int id = Convert.ToInt32(tboxId.Text);
            string nome = tboxNome.Text;
            List<Item> lista = ListaItensTema;

            Tema tema = new Tema(id, nome, lista);

            if (id > 0)
                tema.id = id;

            return tema;
        }

        public void ConfigurarTela(Tema tema)
        {
            tboxId.Text = tema.id.ToString();
            tboxNome.Text = tema.nome;

            foreach(Item registro in tema.ListaItens)
            {
                ListBoxItens.Items.Add($"Nome: {registro.nome} - Valor: R${registro.valor}");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Tema tema = ObterTema();

            string[] erros = tema.ValidarErros();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0], TipoStatusEnum.Erro);
                DialogResult = DialogResult.None;
            }

        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tboxId.Text);
            string nome = txtBoxNomeItem.Text;
            decimal valor = Convert.ToDecimal(txtboxValorItem.Text);

            Item novoItem = new Item(id, nome, valor);
            ListaItensTema.Add(novoItem);

            txtBoxNomeItem.Text = "";
            txtboxValorItem.Text = "";

            ListBoxItens.Items.Add(novoItem);
        }
    }
}

