using PartyManager.Dominio.ModuloCliente;
using PartyManager.Dominio.ModuloFesta;
using PartyManager.Dominio.ModuloTema;
namespace PartyManager.WinApp.ModuloFesta
{
     public partial class TelaFestaForm : Form
     {
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
               tboxEndereco.Text = festaSelecionada.endereco;
               tboxNome.Text = festaSelecionada.nome;
               cbBoxTema.SelectedItem = festaSelecionada.tema;
               cbBoxCliente.SelectedItem = festaSelecionada.cliente;
               txtData.Value = festaSelecionada.data;
               txtHoraInicio.Value = DateTime.Now.Date.Add(festaSelecionada.horaInicio);
               txtHoraFim.Value = DateTime.Now.Date.Add(festaSelecionada.horaTermino);

          }
          public Festa ObterFesta()
          {
               int id = Convert.ToInt32(tboxId.Text);
               string endereco = tboxEndereco.Text;

               Tema tema = (Tema)cbBoxTema.SelectedItem;
               Cliente cliente = (Cliente)cbBoxCliente.SelectedItem;

               DateTime data = txtData.Value;
               TimeSpan horaInicio = txtHoraInicio.Value.TimeOfDay;
               TimeSpan horaTermino = txtHoraFim.Value.TimeOfDay;
               string nome = tboxNome.Text;
               Festa festa = new Festa(id, endereco, tema, cliente, data, horaInicio, horaTermino, nome);

               if (id > 0)
                    festa.id = id;

               return festa;
          }
          private void btnCadastrar_Click(object sender, EventArgs e)
          {
               Festa festa = ObterFesta();
               string[] erros = festa.ValidarErros();

               if (erros.Length > 0)
               {
                    TelaPrincipalForm.Instancia.AtualizarRodape(erros[0], TipoStatusEnum.Erro);

                    DialogResult = DialogResult.None;
               }
          }
     }
}
