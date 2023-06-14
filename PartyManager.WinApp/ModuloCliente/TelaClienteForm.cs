using PartyManager.Dominio.ModuloCliente;

namespace PartyManager.WinApp.ModuloCliente
{
     public partial class TelaClienteForm : Form
     {
          public TelaClienteForm()
          {
               InitializeComponent();
               this.ConfigurarDialog();
          }

          public Cliente ObterCliente()
          {
               int id = Convert.ToInt32(tboxId.Text);
               string nome = tboxNome.Text;
               string telefone = mtboxTelefone.Text;

               Cliente cliente = new Cliente(id, nome, telefone);

               if (id > 0)
                    cliente.id = id;

               return cliente;
          }

          public void ConfigurarTela(Cliente cliente)
          {
               tboxId.Text = cliente.id.ToString();
               tboxNome.Text = cliente.nome;
               mtboxTelefone.Text = cliente.telefone;
          }

          private void btnCadastrar_Click(object sender, EventArgs e)
          {
               Cliente cliente = ObterCliente();

               string[] erros = cliente.ValidarErros();

               if (!mtboxTelefone.MaskFull)
               {
                    Array.Resize(ref erros, erros.Length + 1);
                    erros[erros.Length - 1] = "Campo \"Telefone\" está incompleto!";
               }

               if (erros.Length > 0)
               {
                    TelaPrincipalForm.Instancia.AtualizarRodape(erros[0], TipoStatusEnum.Erro);

                    DialogResult = DialogResult.None;
               }

          }
     }
}
