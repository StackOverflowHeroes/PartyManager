namespace PartyManager.WinApp.ModuloTema
{
    partial class TelaTemaForm
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
            button1 = new Button();
            btnAdicionarItem = new Button();
            ListBoxItens = new ListBox();
            label3 = new Label();
            txtboxValorItem = new TextBox();
            txtBoxNomeItem = new TextBox();
            label4 = new Label();
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
            btnCadastrar.Location = new Point(368, 425);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(86, 60);
            btnCadastrar.TabIndex = 24;
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
            btnCancelar.Location = new Point(460, 425);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 60);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(62, 371);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(438, 34);
            button1.TabIndex = 59;
            button1.Text = "deletar itens selecionados";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.Anchor = AnchorStyles.None;
            btnAdicionarItem.BackColor = SystemColors.ButtonHighlight;
            btnAdicionarItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionarItem.Location = new Point(329, 146);
            btnAdicionarItem.Margin = new Padding(3, 4, 3, 4);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Size = new Size(171, 27);
            btnAdicionarItem.TabIndex = 58;
            btnAdicionarItem.Text = "Adicionar item";
            btnAdicionarItem.UseVisualStyleBackColor = false;
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            // 
            // ListBoxItens
            // 
            ListBoxItens.FormattingEnabled = true;
            ListBoxItens.ItemHeight = 20;
            ListBoxItens.Location = new Point(62, 180);
            ListBoxItens.Name = "ListBoxItens";
            ListBoxItens.Size = new Size(438, 184);
            ListBoxItens.TabIndex = 57;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(62, 146);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 56;
            label3.Text = "Valor";
            // 
            // txtboxValorItem
            // 
            txtboxValorItem.Anchor = AnchorStyles.None;
            txtboxValorItem.Location = new Point(122, 146);
            txtboxValorItem.Margin = new Padding(3, 4, 3, 4);
            txtboxValorItem.Name = "txtboxValorItem";
            txtboxValorItem.Size = new Size(201, 27);
            txtboxValorItem.TabIndex = 55;
            // 
            // txtBoxNomeItem
            // 
            txtBoxNomeItem.Anchor = AnchorStyles.None;
            txtBoxNomeItem.Location = new Point(122, 111);
            txtBoxNomeItem.Margin = new Padding(3, 4, 3, 4);
            txtBoxNomeItem.Name = "txtBoxNomeItem";
            txtBoxNomeItem.Size = new Size(378, 27);
            txtBoxNomeItem.TabIndex = 54;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(62, 111);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 53;
            label4.Text = "Nome";
            // 
            // tboxNome
            // 
            tboxNome.Anchor = AnchorStyles.None;
            tboxNome.Location = new Point(122, 63);
            tboxNome.Margin = new Padding(3, 4, 3, 4);
            tboxNome.Name = "tboxNome";
            tboxNome.Size = new Size(378, 27);
            tboxNome.TabIndex = 52;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(62, 66);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 51;
            label2.Text = "Tema";
            // 
            // tboxId
            // 
            tboxId.Anchor = AnchorStyles.None;
            tboxId.BackColor = SystemColors.ActiveBorder;
            tboxId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tboxId.Location = new Point(277, 28);
            tboxId.Margin = new Padding(3, 4, 3, 4);
            tboxId.Name = "tboxId";
            tboxId.ReadOnly = true;
            tboxId.Size = new Size(62, 27);
            tboxId.TabIndex = 50;
            tboxId.Text = "0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(249, 32);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 49;
            label1.Text = "Nº";
            // 
            // TelaTemaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 501);
            Controls.Add(button1);
            Controls.Add(btnAdicionarItem);
            Controls.Add(ListBoxItens);
            Controls.Add(label3);
            Controls.Add(txtboxValorItem);
            Controls.Add(txtBoxNomeItem);
            Controls.Add(label4);
            Controls.Add(tboxNome);
            Controls.Add(label2);
            Controls.Add(tboxId);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Controls.Add(btnCancelar);
            Name = "TelaTemaForm";
            ShowIcon = false;
            Text = "Cadastro de Temas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Button btnCancelar;
        private Button button1;
        private Button btnAdicionarItem;
        private ListBox ListBoxItens;
        private Label label3;
        private TextBox txtboxValorItem;
        private TextBox txtBoxNomeItem;
        private Label label4;
        private TextBox tboxNome;
        private Label label2;
        private TextBox tboxId;
        private Label label1;
    }
}