namespace PartyManager.WinApp.ModuloCliente
{
     partial class TelaHistoricoClienteForm
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
               gridAlugueisCliente = new DataGridView();
               btnCancelar = new Button();
               ((System.ComponentModel.ISupportInitialize)gridAlugueisCliente).BeginInit();
               SuspendLayout();
               // 
               // gridAlugueisCliente
               // 
               gridAlugueisCliente.AllowUserToAddRows = false;
               gridAlugueisCliente.AllowUserToDeleteRows = false;
               gridAlugueisCliente.AllowUserToResizeRows = false;
               gridAlugueisCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               gridAlugueisCliente.Location = new Point(12, 12);
               gridAlugueisCliente.MultiSelect = false;
               gridAlugueisCliente.Name = "gridAlugueisCliente";
               gridAlugueisCliente.ReadOnly = true;
               gridAlugueisCliente.RowHeadersVisible = false;
               gridAlugueisCliente.RowTemplate.Height = 25;
               gridAlugueisCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
               gridAlugueisCliente.Size = new Size(499, 259);
               gridAlugueisCliente.TabIndex = 0;
               // 
               // btnCancelar
               // 
               btnCancelar.Anchor = AnchorStyles.None;
               btnCancelar.BackColor = SystemColors.ButtonHighlight;
               btnCancelar.DialogResult = DialogResult.Cancel;
               btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               btnCancelar.Location = new Point(436, 277);
               btnCancelar.Name = "btnCancelar";
               btnCancelar.Size = new Size(75, 45);
               btnCancelar.TabIndex = 16;
               btnCancelar.Text = "Cancelar";
               btnCancelar.UseVisualStyleBackColor = false;
               // 
               // TelaHistoricoClienteForm
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(523, 334);
               Controls.Add(btnCancelar);
               Controls.Add(gridAlugueisCliente);
               Name = "TelaHistoricoClienteForm";
               Text = "Visualizando Histórico";
               ((System.ComponentModel.ISupportInitialize)gridAlugueisCliente).EndInit();
               ResumeLayout(false);
          }

          #endregion

          private DataGridView gridAlugueisCliente;
          private Button btnCancelar;
     }
}