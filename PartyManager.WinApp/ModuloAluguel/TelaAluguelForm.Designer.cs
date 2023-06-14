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
            label7 = new Label();
            TextBoxValorEntrada = new TextBox();
            SuspendLayout();
            // 
            // comboBoxFesta
            // 
            comboBoxFesta.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFesta.FormattingEnabled = true;
            comboBoxFesta.Location = new Point(207, 130);
            comboBoxFesta.Name = "comboBoxFesta";
            comboBoxFesta.Size = new Size(239, 28);
            comboBoxFesta.TabIndex = 0;
            comboBoxFesta.SelectedIndexChanged += comboBoxFesta_SelectedIndexChanged;
            // 
            // comboBoxPagamento
            // 
            comboBoxPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPagamento.FormattingEnabled = true;
            comboBoxPagamento.Location = new Point(207, 324);
            comboBoxPagamento.Name = "comboBoxPagamento";
            comboBoxPagamento.Size = new Size(239, 28);
            comboBoxPagamento.TabIndex = 2;
            // 
            // dateAbertura
            // 
            dateAbertura.CustomFormat = "";
            dateAbertura.Format = DateTimePickerFormat.Short;
            dateAbertura.Location = new Point(207, 231);
            dateAbertura.Name = "dateAbertura";
            dateAbertura.Size = new Size(239, 27);
            dateAbertura.TabIndex = 3;
            // 
            // dateFechamento
            // 
            dateFechamento.Format = DateTimePickerFormat.Short;
            dateFechamento.Location = new Point(207, 270);
            dateFechamento.Name = "dateFechamento";
            dateFechamento.Size = new Size(239, 27);
            dateFechamento.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.None;
            btnCadastrar.BackColor = SystemColors.ButtonHighlight;
            btnCadastrar.DialogResult = DialogResult.OK;
            btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(320, 446);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(86, 60);
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
            btnCancelar.Location = new Point(413, 446);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 60);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // tboxId
            // 
            tboxId.Anchor = AnchorStyles.None;
            tboxId.BackColor = SystemColors.ActiveBorder;
            tboxId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tboxId.Location = new Point(250, 46);
            tboxId.Margin = new Padding(3, 4, 3, 4);
            tboxId.Name = "tboxId";
            tboxId.ReadOnly = true;
            tboxId.Size = new Size(62, 27);
            tboxId.TabIndex = 22;
            tboxId.Text = "0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(222, 48);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 21;
            label1.Text = "Nº";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(71, 134);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 23;
            label2.Text = "Festa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(71, 183);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 24;
            label3.Text = "Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(71, 234);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 25;
            label4.Text = "Data abertura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(71, 273);
            label5.Name = "label5";
            label5.Size = new Size(130, 20);
            label5.TabIndex = 26;
            label5.Text = "Data fechamento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(71, 328);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 27;
            label6.Text = "Pagamento";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(207, 180);
            txtCliente.Margin = new Padding(3, 4, 3, 4);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(238, 27);
            txtCliente.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(71, 372);
            label7.Name = "label7";
            label7.Size = new Size(124, 20);
            label7.TabIndex = 29;
            label7.Text = "Valor de Entrada";
            // 
            // TextBoxValorEntrada
            // 
            TextBoxValorEntrada.Enabled = false;
            TextBoxValorEntrada.Location = new Point(207, 369);
            TextBoxValorEntrada.Name = "TextBoxValorEntrada";
            TextBoxValorEntrada.Size = new Size(238, 27);
            TextBoxValorEntrada.TabIndex = 30;
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 519);
            Controls.Add(TextBoxValorEntrada);
            Controls.Add(label7);
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
            Name = "TelaAluguelForm";
            ShowIcon = false;
            Text = "Cadastro de Aluguéis";
            Load += TelaAluguelForm_Load;
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
        private Label label7;
        private TextBox TextBoxValorEntrada;
    }
}