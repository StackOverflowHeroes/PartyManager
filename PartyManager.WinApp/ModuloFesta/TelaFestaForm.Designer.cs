namespace PartyManager.WinApp.ModuloFesta
{
     partial class TelaFestaForm
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
               label2 = new Label();
               tboxEndereco = new TextBox();
               label1 = new Label();
               tboxId = new TextBox();
               btnCadastrar = new Button();
               btnCancelar = new Button();
               label3 = new Label();
               cbBoxTema = new ComboBox();
               label4 = new Label();
               cbBoxCliente = new ComboBox();
               label5 = new Label();
               label6 = new Label();
               label7 = new Label();
               txtHoraInicio = new DateTimePicker();
               txtHoraFim = new DateTimePicker();
               txtData = new DateTimePicker();
               tboxNome = new TextBox();
               label8 = new Label();
               SuspendLayout();
               // 
               // label2
               // 
               label2.Anchor = AnchorStyles.None;
               label2.AutoSize = true;
               label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label2.Location = new Point(55, 121);
               label2.Name = "label2";
               label2.Size = new Size(59, 15);
               label2.TabIndex = 28;
               label2.Text = "Endereço";
               // 
               // tboxEndereco
               // 
               tboxEndereco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
               tboxEndereco.Location = new Point(120, 121);
               tboxEndereco.Name = "tboxEndereco";
               tboxEndereco.Size = new Size(247, 23);
               tboxEndereco.TabIndex = 29;
               // 
               // label1
               // 
               label1.Anchor = AnchorStyles.None;
               label1.AutoSize = true;
               label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label1.Location = new Point(93, 63);
               label1.Name = "label1";
               label1.Size = new Size(21, 15);
               label1.TabIndex = 30;
               label1.Text = "Nº";
               // 
               // tboxId
               // 
               tboxId.Anchor = AnchorStyles.None;
               tboxId.BackColor = SystemColors.ActiveBorder;
               tboxId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               tboxId.Location = new Point(120, 63);
               tboxId.Name = "tboxId";
               tboxId.ReadOnly = true;
               tboxId.Size = new Size(55, 23);
               tboxId.TabIndex = 31;
               tboxId.Text = "0";
               // 
               // btnCadastrar
               // 
               btnCadastrar.Anchor = AnchorStyles.None;
               btnCadastrar.BackColor = SystemColors.ButtonHighlight;
               btnCadastrar.DialogResult = DialogResult.OK;
               btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               btnCadastrar.Location = new Point(211, 320);
               btnCadastrar.Name = "btnCadastrar";
               btnCadastrar.Size = new Size(71, 66);
               btnCadastrar.TabIndex = 32;
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
               btnCancelar.Location = new Point(288, 320);
               btnCancelar.Name = "btnCancelar";
               btnCancelar.Size = new Size(71, 66);
               btnCancelar.TabIndex = 33;
               btnCancelar.Text = "Cancelar";
               btnCancelar.UseVisualStyleBackColor = false;
               // 
               // label3
               // 
               label3.Anchor = AnchorStyles.None;
               label3.AutoSize = true;
               label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label3.Location = new Point(77, 152);
               label3.Name = "label3";
               label3.Size = new Size(37, 15);
               label3.TabIndex = 34;
               label3.Text = "Tema";
               // 
               // cbBoxTema
               // 
               cbBoxTema.Anchor = AnchorStyles.None;
               cbBoxTema.DisplayMember = "nome";
               cbBoxTema.DropDownStyle = ComboBoxStyle.DropDownList;
               cbBoxTema.FormattingEnabled = true;
               cbBoxTema.Location = new Point(120, 152);
               cbBoxTema.Name = "cbBoxTema";
               cbBoxTema.Size = new Size(247, 23);
               cbBoxTema.TabIndex = 35;
               // 
               // label4
               // 
               label4.Anchor = AnchorStyles.None;
               label4.AutoSize = true;
               label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label4.Location = new Point(68, 184);
               label4.Name = "label4";
               label4.Size = new Size(46, 15);
               label4.TabIndex = 36;
               label4.Text = "Cliente";
               // 
               // cbBoxCliente
               // 
               cbBoxCliente.Anchor = AnchorStyles.None;
               cbBoxCliente.AutoCompleteCustomSource.AddRange(new string[] { "Cliente 1" });
               cbBoxCliente.DisplayMember = "nome";
               cbBoxCliente.DropDownStyle = ComboBoxStyle.DropDownList;
               cbBoxCliente.FormattingEnabled = true;
               cbBoxCliente.Location = new Point(120, 184);
               cbBoxCliente.Name = "cbBoxCliente";
               cbBoxCliente.Size = new Size(247, 23);
               cbBoxCliente.TabIndex = 37;
               // 
               // label5
               // 
               label5.Anchor = AnchorStyles.None;
               label5.AutoSize = true;
               label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label5.Location = new Point(81, 213);
               label5.Name = "label5";
               label5.Size = new Size(33, 15);
               label5.TabIndex = 39;
               label5.Text = "Data";
               // 
               // label6
               // 
               label6.Anchor = AnchorStyles.None;
               label6.AutoSize = true;
               label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label6.Location = new Point(29, 242);
               label6.Name = "label6";
               label6.Size = new Size(85, 15);
               label6.TabIndex = 40;
               label6.Text = "Horário Início:";
               // 
               // label7
               // 
               label7.Anchor = AnchorStyles.None;
               label7.AutoSize = true;
               label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label7.Location = new Point(39, 271);
               label7.Name = "label7";
               label7.Size = new Size(75, 15);
               label7.TabIndex = 41;
               label7.Text = "Horário Fim:";
               // 
               // txtHoraInicio
               // 
               txtHoraInicio.Format = DateTimePickerFormat.Time;
               txtHoraInicio.Location = new Point(120, 242);
               txtHoraInicio.Name = "txtHoraInicio";
               txtHoraInicio.ShowUpDown = true;
               txtHoraInicio.Size = new Size(124, 23);
               txtHoraInicio.TabIndex = 42;
               // 
               // txtHoraFim
               // 
               txtHoraFim.Format = DateTimePickerFormat.Time;
               txtHoraFim.Location = new Point(120, 271);
               txtHoraFim.Name = "txtHoraFim";
               txtHoraFim.ShowUpDown = true;
               txtHoraFim.Size = new Size(124, 23);
               txtHoraFim.TabIndex = 43;
               // 
               // txtData
               // 
               txtData.Format = DateTimePickerFormat.Short;
               txtData.Location = new Point(120, 213);
               txtData.Name = "txtData";
               txtData.Size = new Size(124, 23);
               txtData.TabIndex = 44;
               // 
               // tboxNome
               // 
               tboxNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
               tboxNome.Location = new Point(120, 92);
               tboxNome.Name = "tboxNome";
               tboxNome.Size = new Size(247, 23);
               tboxNome.TabIndex = 46;
               // 
               // label8
               // 
               label8.Anchor = AnchorStyles.None;
               label8.AutoSize = true;
               label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               label8.Location = new Point(73, 92);
               label8.Name = "label8";
               label8.Size = new Size(41, 15);
               label8.TabIndex = 45;
               label8.Text = "Nome";
               // 
               // TelaFestaForm
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(513, 408);
               Controls.Add(tboxNome);
               Controls.Add(label8);
               Controls.Add(txtData);
               Controls.Add(txtHoraFim);
               Controls.Add(txtHoraInicio);
               Controls.Add(label7);
               Controls.Add(label6);
               Controls.Add(label5);
               Controls.Add(cbBoxCliente);
               Controls.Add(label4);
               Controls.Add(cbBoxTema);
               Controls.Add(label3);
               Controls.Add(btnCancelar);
               Controls.Add(btnCadastrar);
               Controls.Add(tboxId);
               Controls.Add(label1);
               Controls.Add(tboxEndereco);
               Controls.Add(label2);
               Name = "TelaFestaForm";
               Text = "TelaFestaForm";
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private Label label2;
          private TextBox tboxEndereco;
          private Label label1;
          private TextBox tboxId;
          private Button btnCadastrar;
          private Button btnCancelar;
          private Label label3;
          private ComboBox cbBoxTema;
          private Label label4;
          private ComboBox cbBoxCliente;
          private Label label5;
          private Label label6;
          private Label label7;
          private DateTimePicker txtHoraInicio;
          private DateTimePicker txtHoraFim;
          private DateTimePicker txtData;
          private TextBox tboxNome;
          private Label label8;
     }
}