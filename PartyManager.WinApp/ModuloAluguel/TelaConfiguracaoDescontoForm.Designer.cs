namespace PartyManager.WinApp.ModuloAluguel
{
    partial class TelaConfiguracaoDescontoForm
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
            btnCancelar = new Button();
            btnGravar = new Button();
            groupBox1 = new GroupBox();
            txtPorcentagemMaxima = new NumericUpDown();
            lblPorcentagemMaxima = new Label();
            txtPorcentagemAluguel = new NumericUpDown();
            lblPorcentagemAluguel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPorcentagemMaxima).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPorcentagemAluguel).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(310, 285);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 55);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(217, 285);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(86, 55);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPorcentagemMaxima);
            groupBox1.Controls.Add(lblPorcentagemMaxima);
            groupBox1.Controls.Add(txtPorcentagemAluguel);
            groupBox1.Controls.Add(lblPorcentagemAluguel);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(37, 34);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(359, 237);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Porcentagens de Desconto:";
            // 
            // txtPorcentagemMaxima
            // 
            txtPorcentagemMaxima.DecimalPlaces = 2;
            txtPorcentagemMaxima.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPorcentagemMaxima.Location = new Point(245, 163);
            txtPorcentagemMaxima.Margin = new Padding(3, 4, 3, 4);
            txtPorcentagemMaxima.Name = "txtPorcentagemMaxima";
            txtPorcentagemMaxima.Size = new Size(80, 27);
            txtPorcentagemMaxima.TabIndex = 3;
            // 
            // lblPorcentagemMaxima
            // 
            lblPorcentagemMaxima.AutoEllipsis = true;
            lblPorcentagemMaxima.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPorcentagemMaxima.Location = new Point(38, 163);
            lblPorcentagemMaxima.Name = "lblPorcentagemMaxima";
            lblPorcentagemMaxima.Size = new Size(157, 27);
            lblPorcentagemMaxima.TabIndex = 2;
            lblPorcentagemMaxima.Text = "Máximo de Desconto:";
            lblPorcentagemMaxima.TextAlign = ContentAlignment.TopRight;
            // 
            // txtPorcentagemAluguel
            // 
            txtPorcentagemAluguel.DecimalPlaces = 2;
            txtPorcentagemAluguel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPorcentagemAluguel.Location = new Point(245, 81);
            txtPorcentagemAluguel.Margin = new Padding(3, 4, 3, 4);
            txtPorcentagemAluguel.Name = "txtPorcentagemAluguel";
            txtPorcentagemAluguel.Size = new Size(80, 27);
            txtPorcentagemAluguel.TabIndex = 1;
            // 
            // lblPorcentagemAluguel
            // 
            lblPorcentagemAluguel.AutoSize = true;
            lblPorcentagemAluguel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPorcentagemAluguel.Location = new Point(38, 85);
            lblPorcentagemAluguel.Name = "lblPorcentagemAluguel";
            lblPorcentagemAluguel.Size = new Size(181, 20);
            lblPorcentagemAluguel.TabIndex = 0;
            lblPorcentagemAluguel.Text = "Porcentagem por Aluguel:";
            // 
            // TelaConfiguracaoDescontoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 353);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(groupBox1);
            Name = "TelaConfiguracaoDescontoForm";
            Text = "TelaConfiguracaoAluguelForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPorcentagemMaxima).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPorcentagemAluguel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private GroupBox groupBox1;
        private NumericUpDown txtPorcentagemMaxima;
        private Label lblPorcentagemMaxima;
        private NumericUpDown txtPorcentagemAluguel;
        private Label lblPorcentagemAluguel;
    }
}