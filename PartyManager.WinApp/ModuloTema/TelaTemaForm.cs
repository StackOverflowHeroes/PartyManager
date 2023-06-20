using PartyManager.Dominio.ModuloItens;
using PartyManager.Dominio.ModuloTema;

namespace PartyManager.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        private List<Tema> temas;
        private List<Item> ListaItensTema = new List<Item>();
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

            ListaItensSelecionados.ForEach(item => item.MarcarComoSelecionado());

            ListaItensTema.AddRange(ListaItensSelecionados);

            Tema tema = new Tema(id, nome, ListaItensTema);

            if (id > 0)
                tema.id = id;

            return tema;
        }

        public void ConfigurarTela(Tema tema, List<Item> ListaCompleta)
        {
            tboxId.Text = tema.id.ToString();
            tboxNome.Text = tema.nome;

            ListaItensTema.Clear();

            List<Item> ListaItensCompleta = ListaCompleta.Except(tema.ListaItens).ToList();

            foreach (Item registro in tema.ListaItens)
            {
                CheckListBoxItens.Items.Add(registro, true);
            }

            foreach (Item registro in ListaItensCompleta)
            {
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

            if (temas != null)
            {
                if (temas.Exists(x => x.nome.ToLower() == tema.nome.ToLower()))
                {
                    string erro = "Tema já cadastrado, entre com um nome diferente!";

                    if (erros.Length == 0 || erros[erros.Length - 1] != erro)
                    {
                        Array.Resize(ref erros, erros.Length + 1);
                        erros[erros.Length - 1] = erro;
                    }
                }
            }


            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0], TipoStatusEnum.Erro);
                DialogResult = DialogResult.None;
            }
        }

        public void PegarListaNome(List<Tema> temas)
        {
            this.temas = temas;
        }

    }
}

