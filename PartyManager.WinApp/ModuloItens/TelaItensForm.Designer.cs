namespace PartyManager.WinApp.ModuloItens
{
    partial class TelaItensForm
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
            label3 = new Label();
            txtboxValorItem = new TextBox();
            txtBoxNomeItem = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            tboxId = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(83, 142);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 63;
            label3.Text = "Valor";
            // 
            // txtboxValorItem
            // 
            txtboxValorItem.Anchor = AnchorStyles.None;
            txtboxValorItem.Location = new Point(143, 142);
            txtboxValorItem.Margin = new Padding(3, 4, 3, 4);
            txtboxValorItem.Name = "txtboxValorItem";
            txtboxValorItem.Size = new Size(378, 27);
            txtboxValorItem.TabIndex = 62;
            // 
            // txtBoxNomeItem
            // 
            txtBoxNomeItem.Anchor = AnchorStyles.None;
            txtBoxNomeItem.Location = new Point(143, 107);
            txtBoxNomeItem.Margin = new Padding(3, 4, 3, 4);
            txtBoxNomeItem.Name = "txtBoxNomeItem";
            txtBoxNomeItem.Size = new Size(378, 27);
            txtBoxNomeItem.TabIndex = 61;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(83, 107);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 60;
            label4.Text = "Nome";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(408, 212);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 60);
            button1.TabIndex = 67;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnCadastrar_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(500, 212);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 60);
            button2.TabIndex = 66;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // tboxId
            // 
            tboxId.Anchor = AnchorStyles.None;
            tboxId.BackColor = SystemColors.ActiveBorder;
            tboxId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tboxId.Location = new Point(309, 63);
            tboxId.Margin = new Padding(3, 4, 3, 4);
            tboxId.Name = "tboxId";
            tboxId.ReadOnly = true;
            tboxId.Size = new Size(62, 27);
            tboxId.TabIndex = 69;
            tboxId.Text = "0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(281, 67);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 68;
            label1.Text = "Nº";
            // 
            // TelaItensForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 285);
            Controls.Add(tboxId);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(txtboxValorItem);
            Controls.Add(txtBoxNomeItem);
            Controls.Add(label4);
            Name = "TelaItensForm";
            Text = "TelaItensForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtboxValorItem;
        private TextBox txtBoxNomeItem;
        private Label label4;
        private Button button1;
        private Button button2;
        private TextBox tboxId;
        private Label label1;
    }
}