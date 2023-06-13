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
            comboBoxCliente = new ComboBox();
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
            SuspendLayout();
            // 
            // comboBoxFesta
            // 
            comboBoxFesta.DisplayMember = "cliente.nome";
            comboBoxFesta.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFesta.FormattingEnabled = true;
            comboBoxFesta.Location = new Point(65, 100);
            comboBoxFesta.Name = "comboBoxFesta";
            comboBoxFesta.Size = new Size(375, 28);
            comboBoxFesta.TabIndex = 0;
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.DisplayMember = "nome";
            comboBoxCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(65, 156);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(375, 28);
            comboBoxCliente.TabIndex = 1;
            // 
            // comboBoxPagamento
            // 
            comboBoxPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPagamento.FormattingEnabled = true;
            comboBoxPagamento.Location = new Point(65, 295);
            comboBoxPagamento.Name = "comboBoxPagamento";
            comboBoxPagamento.Size = new Size(375, 28);
            comboBoxPagamento.TabIndex = 2;
            // 
            // dateAbertura
            // 
            dateAbertura.Format = DateTimePickerFormat.Short;
            dateAbertura.Location = new Point(190, 201);
            dateAbertura.Name = "dateAbertura";
            dateAbertura.Size = new Size(250, 27);
            dateAbertura.TabIndex = 3;
            // 
            // dateFechamento
            // 
            dateFechamento.Format = DateTimePickerFormat.Short;
            dateFechamento.Location = new Point(190, 239);
            dateFechamento.Name = "dateFechamento";
            dateFechamento.Size = new Size(250, 27);
            dateFechamento.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.None;
            btnCadastrar.BackColor = SystemColors.ButtonHighlight;
            btnCadastrar.DialogResult = DialogResult.OK;
            btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(320, 373);
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
            btnCancelar.Location = new Point(413, 373);
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
            tboxId.Location = new Point(226, 26);
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
            label1.Location = new Point(198, 30);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 21;
            label1.Text = "Nº";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 77);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 23;
            label2.Text = "Festa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 131);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 24;
            label3.Text = "Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 204);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 25;
            label4.Text = "Data abertura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 242);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 26;
            label5.Text = "Data fechamento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 272);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 27;
            label6.Text = "Pagamento";
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 446);
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
            Controls.Add(comboBoxCliente);
            Controls.Add(comboBoxFesta);
            Name = "TelaAluguelForm";
            ShowIcon = false;
            Text = "Cadastro de Aluguéis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFesta;
        private ComboBox comboBoxCliente;
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
    }
}