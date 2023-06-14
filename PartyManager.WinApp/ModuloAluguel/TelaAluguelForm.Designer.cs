namespace PartyManager.WinApp.ModuloAluguel
{
    partial class TelaAluguelForm
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
            comboBoxFesta = new ComboBox();
            comboBoxPagamento = new ComboBox();
            dateAbertura = new DateTimePicker();
            dateFechamento = new DateTimePicker();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            tboxId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCliente = new TextBox();
            SuspendLayout();
            // 
            // comboBoxFesta
            // 
            comboBoxFesta.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFesta.FormattingEnabled = true;
            comboBoxFesta.Location = new Point(57, 75);
            comboBoxFesta.Margin = new Padding(3, 2, 3, 2);
            comboBoxFesta.Name = "comboBoxFesta";
            comboBoxFesta.Size = new Size(329, 23);
            comboBoxFesta.TabIndex = 0;
            comboBoxFesta.SelectedIndexChanged += comboBoxFesta_SelectedIndexChanged;
            // 
            // comboBoxPagamento
            // 
            comboBoxPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPagamento.FormattingEnabled = true;
            comboBoxPagamento.Location = new Point(57, 221);
            comboBoxPagamento.Margin = new Padding(3, 2, 3, 2);
            comboBoxPagamento.Name = "comboBoxPagamento";
            comboBoxPagamento.Size = new Size(329, 23);
            comboBoxPagamento.TabIndex = 2;
            // 
            // dateAbertura
            // 
            dateAbertura.CustomFormat = "";
            dateAbertura.Format = DateTimePickerFormat.Short;
            dateAbertura.Location = new Point(166, 151);
            dateAbertura.Margin = new Padding(3, 2, 3, 2);
            dateAbertura.Name = "dateAbertura";
            dateAbertura.Size = new Size(219, 23);
            dateAbertura.TabIndex = 3;
            // 
            // dateFechamento
            // 
            dateFechamento.Format = DateTimePickerFormat.Short;
            dateFechamento.Location = new Point(166, 179);
            dateFechamento.Margin = new Padding(3, 2, 3, 2);
            dateFechamento.Name = "dateFechamento";
            dateFechamento.Size = new Size(219, 23);
            dateFechamento.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.None;
            btnCadastrar.BackColor = SystemColors.ButtonHighlight;
            btnCadastrar.DialogResult = DialogResult.OK;
            btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(280, 280);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 45);
            btnCadastrar.TabIndex = 18;
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
            btnCancelar.Location = new Point(361, 280);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 45);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // tboxId
            // 
            tboxId.Anchor = AnchorStyles.None;
            tboxId.BackColor = SystemColors.ActiveBorder;
            tboxId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tboxId.Location = new Point(198, 20);
            tboxId.Name = "tboxId";
            tboxId.ReadOnly = true;
            tboxId.Size = new Size(55, 23);
            tboxId.TabIndex = 22;
            tboxId.Text = "0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(173, 22);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 21;
            label1.Text = "Nº";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 58);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 23;
            label2.Text = "Festa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 98);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 24;
            label3.Text = "Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 153);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 25;
            label4.Text = "Data abertura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 182);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 26;
            label5.Text = "Data fechamento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 204);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 27;
            label6.Text = "Pagamento";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(57, 115);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(328, 23);
            txtCliente.TabIndex = 28;
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 334);
            Controls.Add(txtCliente);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tboxId);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Controls.Add(btnCancelar);
            Controls.Add(dateFechamento);
            Controls.Add(dateAbertura);
            Controls.Add(comboBoxPagamento);
            Controls.Add(comboBoxFesta);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaAluguelForm";
            ShowIcon = false;
            Text = "Cadastro de Aluguéis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFesta;
        private ComboBox comboBoxPagamento;
        private DateTimePicker dateAbertura;
        private DateTimePicker dateFechamento;
        private Button btnCadastrar;
        private Button btnCancelar;
        private TextBox tboxId;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCliente;
    }
}