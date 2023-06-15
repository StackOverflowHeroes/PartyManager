namespace PartyManager.WinApp.ModuloItens
{
    partial class TabelaItensControl
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
            tabelaItens = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelaItens).BeginInit();
            SuspendLayout();
            // 
            // tabelaItens
            // 
            tabelaItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaItens.Dock = DockStyle.Fill;
            tabelaItens.Location = new Point(0, 0);
            tabelaItens.Name = "tabelaItens";
            tabelaItens.RowHeadersWidth = 51;
            tabelaItens.RowTemplate.Height = 29;
            tabelaItens.Size = new Size(544, 512);
            tabelaItens.TabIndex = 0;
            // 
            // TabelaItensControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabelaItens);
            Name = "TabelaItensControl";
            Size = new Size(544, 512);
            ((System.ComponentModel.ISupportInitialize)tabelaItens).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaItens;
    }
}
