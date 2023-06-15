using PartyManager.Dominio.ModuloItens;
using PartyManager.Dominio.ModuloTema;

namespace PartyManager.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        private List<Item> ListaItensTema =new List<Item>();
        public TelaTemaForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public Tema ObterTema()
        {
            int id = Convert.ToInt32(tboxId.Text);
            string nome = tboxNome.Text;

            ListaItensTema.Clear();

            List<Item> ListaItensSelecionados = PegarItensSelecionados();
            List<Item> ListaItensNaoSelecionados = PegarItensNaoSelecionados();

            ListaItensSelecionados.ForEach(item => item.MarcarComoSelecionado());
            ListaItensNaoSelecionados.ForEach(item => item.MarcarComoNaoSelecionado());

            ListaItensTema.AddRange(ListaItensSelecionados);
            ListaItensTema.AddRange(ListaItensNaoSelecionados);

            Tema tema = new Tema(id, nome, ListaItensTema);

            if (id > 0)
                tema.id = id;

            return tema;
        }

        public void ConfigurarTela(Tema tema)
        {
            tboxId.Text = tema.id.ToString();
            tboxNome.Text = tema.nome;

            ListaItensTema.Clear();

            foreach (Item registro in tema.ListaItens)
            {
                if (registro.statusItem == true)
                    CheckListBoxItens.Items.Add(registro, true);
                else
                    CheckListBoxItens.Items.Add(registro, false); 
            }
        }

        public List<Item> PegarItensNaoSelecionados()
        {
            return CheckListBoxItens.Items.Cast<Item>().Except(PegarItensSelecionados()).ToList();
        }

        public List<Item> PegarItensSelecionados()
        {
            return CheckListBoxItens.CheckedItems.Cast<Item>().ToList();
        }

        public void PopularCheckedListBox(List<Item> listaCompletaItens)
        {
            foreach (Item registro in listaCompletaItens)
            {
                CheckListBoxItens.Items.Add(registro);
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
    }
}

