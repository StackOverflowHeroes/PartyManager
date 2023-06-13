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
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(63, 161);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 28;
            label2.Text = "Endereço";
            // 
            // tboxEndereco
            // 
            tboxEndereco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tboxEndereco.Location = new Point(137, 161);
            tboxEndereco.Margin = new Padding(3, 4, 3, 4);
            tboxEndereco.Name = "tboxEndereco";
            tboxEndereco.Size = new Size(282, 27);
            tboxEndereco.TabIndex = 29;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(106, 123);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 30;
            label1.Text = "Nº";
            // 
            // tboxId
            // 
            tboxId.Anchor = AnchorStyles.None;
            tboxId.BackColor = SystemColors.ActiveBorder;
            tboxId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tboxId.Location = new Point(137, 123);
            tboxId.Margin = new Padding(3, 4, 3, 4);
            tboxId.Name = "tboxId";
            tboxId.ReadOnly = true;
            tboxId.Size = new Size(62, 27);
            tboxId.TabIndex = 31;
            tboxId.Text = "0";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.None;
            btnCadastrar.BackColor = SystemColors.ButtonHighlight;
            btnCadastrar.DialogResult = DialogResult.OK;
            btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(241, 427);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(81, 88);
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
            btnCancelar.Location = new Point(329, 427);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 88);
            btnCancelar.TabIndex = 33;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(88, 203);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 34;
            label3.Text = "Tema";
            // 
            // cbBoxTema
            // 
            cbBoxTema.Anchor = AnchorStyles.None;
            cbBoxTema.DisplayMember = "nome";
            cbBoxTema.FormattingEnabled = true;
            cbBoxTema.Location = new Point(137, 203);
            cbBoxTema.Margin = new Padding(3, 4, 3, 4);
            cbBoxTema.Name = "cbBoxTema";
            cbBoxTema.Size = new Size(282, 28);
            cbBoxTema.TabIndex = 35;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(78, 245);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 36;
            label4.Text = "Cliente";
            // 
            // cbBoxCliente
            // 
            cbBoxCliente.Anchor = AnchorStyles.None;
            cbBoxCliente.AutoCompleteCustomSource.AddRange(new string[] { "Cliente 1" });
            cbBoxCliente.DisplayMember = "nome";
            cbBoxCliente.FormattingEnabled = true;
            cbBoxCliente.Location = new Point(137, 245);
            cbBoxCliente.Margin = new Padding(3, 4, 3, 4);
            cbBoxCliente.Name = "cbBoxCliente";
            cbBoxCliente.Size = new Size(282, 28);
            cbBoxCliente.TabIndex = 37;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(93, 284);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 39;
            label5.Text = "Data";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(33, 323);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 40;
            label6.Text = "Horário Início:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(45, 361);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 41;
            label7.Text = "Horário Fim:";
            // 
            // txtHoraInicio
            // 
            txtHoraInicio.Format = DateTimePickerFormat.Time;
            txtHoraInicio.Location = new Point(137, 323);
            txtHoraInicio.Margin = new Padding(3, 4, 3, 4);
            txtHoraInicio.Name = "txtHoraInicio";
            txtHoraInicio.ShowUpDown = true;
            txtHoraInicio.Size = new Size(141, 27);
            txtHoraInicio.TabIndex = 42;
            // 
            // txtHoraFim
            // 
            txtHoraFim.Format = DateTimePickerFormat.Time;
            txtHoraFim.Location = new Point(137, 361);
            txtHoraFim.Margin = new Padding(3, 4, 3, 4);
            txtHoraFim.Name = "txtHoraFim";
            txtHoraFim.ShowUpDown = true;
            txtHoraFim.Size = new Size(141, 27);
            txtHoraFim.TabIndex = 43;
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(137, 284);
            txtData.Margin = new Padding(3, 4, 3, 4);
            txtData.Name = "txtData";
            txtData.Size = new Size(141, 27);
            txtData.TabIndex = 44;
            // 
            // TelaFestaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 544);
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
            Margin = new Padding(3, 4, 3, 4);
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
    }
}