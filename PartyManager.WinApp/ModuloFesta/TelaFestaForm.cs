using PartyManager.Dominio.ModuloCliente;
using PartyManager.Dominio.ModuloFesta;
using PartyManager.Dominio.ModuloTema;

namespace PartyManager.WinApp.ModuloFesta
{
     public partial class TelaFestaForm : Form
     {
          private List<Festa> festas;
          private string erro;
          public TelaFestaForm(List<Cliente> clientes, List<Tema> temas)
          {
               InitializeComponent();
               this.ConfigurarDialog();
               CarregarCliente(clientes);
               CarregarTema(temas);
          }

          private void CarregarTema(List<Tema> temas)
          {
               foreach (Tema tema in temas)
               {
                    cbBoxTema.Items.Add(tema);
               }
          }

          private void CarregarCliente(List<Cliente> clientes)
          {
               foreach (Cliente cliente in clientes)
               {
                    cbBoxCliente.Items.Add(cliente);
               }
          }

          public void ConfigurarTela(Festa festaSelecionada)
          {
               tboxId.Text = festaSelecionada.id.ToString();
               tboxNome.Text = festaSelecionada.nome;
               cbBoxTema.SelectedItem = festaSelecionada.tema;
               cbBoxCliente.SelectedItem = festaSelecionada.cliente;
               txtData.Value = festaSelecionada.data;
               txtHoraInicio.Value = DateTime.Now.Date.Add(festaSelecionada.horaInicio);
               txtHoraFim.Value = DateTime.Now.Date.Add(festaSelecionada.horaTermino);
               tboxCidade.Text = festaSelecionada.cidade;
               tboxNumero.Text = festaSelecionada.numero.ToString();
               tboxRua.Text = festaSelecionada.cidade;
          }
          public Festa ObterFesta()
          {
               int id = Convert.ToInt32(tboxId.Text);

               Tema tema = (Tema)cbBoxTema.SelectedItem;
               Cliente cliente = (Cliente)cbBoxCliente.SelectedItem;

               DateTime data = txtData.Value;
               TimeSpan horaInicio = txtHoraInicio.Value.TimeOfDay;
               TimeSpan horaTermino = txtHoraFim.Value.TimeOfDay;
               string nome = tboxNome.Text;
               string cidade = tboxCidade.Text;
               string rua = tboxRua.Text;
               int numero = 0;
               try
               {
                    numero = Convert.ToInt32(tboxNumero.Text);
               }
               catch(FormatException)
               {
                    erro = "Campo \"Número\" deve ser um inteiro!";
               }

               Festa festa = new Festa(id, tema, cliente, data, horaInicio, horaTermino, nome, cidade, rua, numero);

               if (id > 0)
                    festa.id = id;

               return festa;
          }
          private void btnCadastrar_Click(object sender, EventArgs e)
          {
               Festa festa = ObterFesta();
               string[] erros = festa.ValidarErros();

               if (!int.TryParse(tboxNumero.Text, out int result))
               {
                    if (erros.Length == 0 || erros[erros.Length - 1] != erro)
                    {
                         Array.Resize(ref erros, erros.Length + 1);
                         erros[erros.Length - 1] = erro;
                    }
               }

               if (festas != null)
               {
                    if (festas.Exists(x => x.nome == festa.nome.ToLower()))
                    {
                         string erro = "Nome já cadastrado, entre com um nome diferente!";

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
          public void PegarListaNome(List<Festa> festas)
          {
               this.festas = festas;
          }
     }
}
