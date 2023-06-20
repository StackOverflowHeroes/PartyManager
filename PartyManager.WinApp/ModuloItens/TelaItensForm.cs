
using PartyManager.Dominio.ModuloCliente;
using PartyManager.Dominio.ModuloItens;

namespace PartyManager.WinApp.ModuloItens
{
    public partial class TelaItensForm : Form
    {
        private List<Item> itens;
        List<string> erros = new List<string>();
        public TelaItensForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public Item ObterItem()
        {
            int id = Convert.ToInt32(tboxId.Text);
            string nome = txtBoxNomeItem.Text;
            decimal valor = 0;

            try
            {
                valor = Convert.ToDecimal(txtboxValorItem.Text);
            }
            catch (FormatException)
            {
                erros.Add("O campo \"Valor\" em itens deve ser numérico!");
            }

            Item novoItem = new Item(id, nome, valor);


            if (id > 0)
                novoItem.id = id;

            return novoItem;
        }

        public void ConfigurarTela(Item item)
        {
            tboxId.Text = item.id.ToString();
            txtBoxNomeItem.Text = item.nome;
            txtboxValorItem.Text = item.valor.ToString();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Item item = ObterItem();

            string[] erros = item.ValidarErros();


            if (itens.Exists(x => x.nome.ToLower() == item.nome.ToLower()))
            {
                string erro = "Item já cadastrado, entre com um nome diferente!";

                if (erros.Length == 0 || erros[erros.Length - 1] != erro)
                {
                    Array.Resize(ref erros, erros.Length + 1);
                    erros[erros.Length - 1] = erro;
                }
            }

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0], TipoStatusEnum.Erro);
                DialogResult = DialogResult.None;
            }
        }

        public void PegarListaNome(List<Item> itens)
        {
            this.itens = itens;
        }
    }
}
