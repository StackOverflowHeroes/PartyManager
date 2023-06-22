namespace PartyManager.WinApp.ModuloCliente
{
     partial class TelaClienteForm
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               btnCadastrar = new Button();
               btnCancelar = new Button();
               mtboxTelefone = new MaskedTextBox();
               label3 = new Label();
               tboxNome = new TextBox();
               label2 = new Label();
               tboxId = new TextBox();
               label1 = new Label();
               SuspendLayout();
               // 
               // btnCadastrar
               // 
               btnCadastrar.Anchor = AnchorStyles.None;
               btnCadastrar.BackColor = SystemColors.ButtonHighlight;
               btnCadastrar.DialogResult = DialogResult.OK;
               btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               btnCadastrar.Location = new Point(279, 277);
               btnCadastrar.Name = "btnCadastrar";
               btnCadastrar.Size = new Size(75, 45);
               btnCadastrar.TabIndex = 16;
               btnCadastrar.Text = "Cadastrar";
               btnCadastrar.UseVisualStyleBackColor = false;
               btnCadastrar.Click += btnCadastrar_Click;
               // 
               // btnCancelar
               // 
               btnCancelar.Anchor = AnchorStyles.None;
               btnCancelar.BackColor = SystemColors.ButtonHighlight;
               btnCancelar.DialogResult = DialogResult.Cancel;
               btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               btnCancelar.Location = new Point(360, 277);
               btnCancelar.Name = "btnCancelar";
               btnCancelar.Size = new Size(75, 45);
               btnCancelar.TabIndex = 15;
               btnCancelar.Text = "Cancelar";
               btnCancelar.UseVisualStyleBackColor = false;
               // 
               // mtboxTelefone
               // 
               mtboxTelefone.AllowPromptAsInput = false;
               mtboxTelefone.Anchor = AnchorStyles.None;
               mtboxTelefone.HideSelection = false;
               mtboxTelefone.Location = new Point(115, 179);
               mtboxTelefone.Mask = "(00) 90000-0000";
               mtboxTelefone.Name = "mtboxTelefone";
               mtboxTelefone.RejectInputOnFirstFailure = true;
               mtboxTelefone.Size = new Size(251, 23);
               mtboxTelefone.TabIndex = 18;
               // 
               // label3
               // 
               label3.Anchor = AnchorStyles.None;
               label3.AutoSize = true;
               label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label3.Location = new Point(56, 182);
               label3.Name = "label3";
               label3.Size = new Size(56, 15);
               label3.TabIndex = 17;
               label3.Text = "Telefone";
               // 
               // tboxNome
               // 
               tboxNome.Anchor = AnchorStyles.None;
               tboxNome.Location = new Point(115, 137);
               tboxNome.Name = "tboxNome";
               tboxNome.Size = new Size(251, 23);
               tboxNome.TabIndex = 22;
               // 
               // label2
               // 
               label2.Anchor = AnchorStyles.None;
               label2.AutoSize = true;
               label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label2.Location = new Point(71, 140);
               label2.Name = "label2";
               label2.Size = new Size(41, 15);
               label2.TabIndex = 21;
               label2.Text = "Nome";
               // 
               // tboxId
               // 
               tboxId.Anchor = AnchorStyles.None;
               tboxId.BackColor = SystemColors.ActiveBorder;
               tboxId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               tboxId.Location = new Point(202, 88);
               tboxId.Name = "tboxId";
               tboxId.ReadOnly = true;
               tboxId.Size = new Size(55, 23);
               tboxId.TabIndex = 20;
               tboxId.Text = "0";
               // 
               // label1
               // 
               label1.Anchor = AnchorStyles.None;
               label1.AutoSize = true;
               label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label1.Location = new Point(178, 91);
               label1.Name = "label1";
               label1.Size = new Size(21, 15);
               label1.TabIndex = 19;
               label1.Text = "Nº";
               // 
               // TelaClienteForm
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(447, 334);
               Controls.Add(tboxNome);
               Controls.Add(label2);
               Controls.Add(tboxId);
               Controls.Add(label1);
               Controls.Add(mtboxTelefone);
               Controls.Add(label3);
               Controls.Add(btnCadastrar);
               Controls.Add(btnCancelar);
               Name = "TelaClienteForm";
               Text = "Cadastro de Clientes";
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private Button btnCadastrar;
          private Button btnCancelar;
          private MaskedTextBox mtboxTelefone;
          private Label label3;
          private TextBox tboxNome;
          private Label label2;
          private TextBox tboxId;
          private Label label1;
     }
}