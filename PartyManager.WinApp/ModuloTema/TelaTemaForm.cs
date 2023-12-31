﻿using PartyManager.Dominio.ModuloTema;

namespace PartyManager.WinApp.ModuloTema
{
     public partial class TelaTemaForm : Form
     {
          List<Item> ListaItensTema = new List<Item>();
          List<string> erros = new List<string>();
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

               foreach (Item registro in tema.ListaItens)
               {
                    ListBoxItens.Items.Add(registro);
                    ListaItensTema.Add(registro);
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
               erros.Clear();
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

               erros.AddRange(novoItem.ValidarErros());

               if (erros.Count > 0)
               {
                    TelaPrincipalForm.Instancia.AtualizarRodape(erros[0], TipoStatusEnum.Erro);
                    return;
               }

               ListaItensTema.Add(novoItem);

               txtBoxNomeItem.Text = "";
               txtboxValorItem.Text = "";

               ListBoxItens.Items.Add(novoItem);
          }

          private void button1_Click(object sender, EventArgs e)
          {
               Item item = ListBoxItens.SelectedItem as Item;
               ListBoxItens.Items.Remove(item);
               ListaItensTema.Remove(item);
          }
     }
}

