﻿using PartyManager.Dominio.ModuloCliente;
using System;

namespace PartyManager.WinApp.ModuloCliente
{
     public partial class TelaClienteForm : Form
     {
          private List<Cliente> clientes;
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
                    string erro = "Campo \"Telefone\" está incompleto!";

                    if (erros.Length == 0 || erros[erros.Length - 1] != erro)
                    {
                         Array.Resize(ref erros, erros.Length + 1);
                         erros[erros.Length - 1] = erro;
                    }
               }

               if (clientes != null)
               {
                    if (clientes.Exists(x => x.nome == cliente.nome.ToLower()))
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

          public void PegarListaNome(List<Cliente> clientes)
          {
               this.clientes = clientes;     
          }
     }
}
