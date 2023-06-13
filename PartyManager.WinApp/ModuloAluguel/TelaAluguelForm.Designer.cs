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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
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
            // comboBox1
            // 
            comboBox1.DisplayMember = "nome";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(65, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(375, 28);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.DisplayMember = "nome";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(65, 156);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(375, 28);
            comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(65, 295);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(375, 28);
            comboBox3.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(190, 191);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(190, 229);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 4;
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
            label4.Location = new Point(65, 194);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 25;
            label4.Text = "Data abertura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 232);
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
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "TelaAluguelForm";
            ShowIcon = false;
            Text = "Cadastro de Aluguéis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
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