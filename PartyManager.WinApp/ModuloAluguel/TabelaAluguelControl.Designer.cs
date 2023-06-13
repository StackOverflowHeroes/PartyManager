namespace PartyManager.WinApp.ModuloAluguel
{
    partial class TabelaAluguelControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabelaAluguel = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelaAluguel).BeginInit();
            SuspendLayout();
            // 
            // tabelaAluguel
            // 
            tabelaAluguel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaAluguel.Dock = DockStyle.Fill;
            tabelaAluguel.Location = new Point(0, 0);
            tabelaAluguel.Name = "tabelaAluguel";
            tabelaAluguel.RowHeadersWidth = 51;
            tabelaAluguel.RowTemplate.Height = 29;
            tabelaAluguel.Size = new Size(645, 524);
            tabelaAluguel.TabIndex = 0;
            // 
            // TabelaAluguelControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabelaAluguel);
            Name = "TabelaAluguelControl";
            Size = new Size(645, 524);
            ((System.ComponentModel.ISupportInitialize)tabelaAluguel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaAluguel;
    }
}
