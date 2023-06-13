namespace PartyManager.WinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            statusStrip1 = new StatusStrip();
            tssStatus = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            cadastrosMenuItem = new ToolStripMenuItem();
            clientesMenuItem = new ToolStripMenuItem();
            temasToolStripMenuItem = new ToolStripMenuItem();
            festasMenuItem = new ToolStripMenuItem();
            aluguéisToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnDeletar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tslTipoCadastros = new ToolStripLabel();
            panelRegistros = new Panel();
            temporizador = new System.Windows.Forms.Timer(components);
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tssStatus });
            statusStrip1.Location = new Point(0, 575);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1026, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            tssStatus.Name = "tssStatus";
            tssStatus.Size = new Size(49, 20);
            tssStatus.Text = "Status";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1026, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosMenuItem
            // 
            cadastrosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesMenuItem, temasToolStripMenuItem, festasMenuItem, aluguéisToolStripMenuItem });
            cadastrosMenuItem.Name = "cadastrosMenuItem";
            cadastrosMenuItem.Size = new Size(88, 24);
            cadastrosMenuItem.Text = "Cadastros";
            // 
            // clientesMenuItem
            // 
            clientesMenuItem.Name = "clientesMenuItem";
            clientesMenuItem.Size = new Size(224, 26);
            clientesMenuItem.Text = "Clientes";
            clientesMenuItem.Click += clientesMenuItem_Click;
            // 
            // temasToolStripMenuItem
            // 
            temasToolStripMenuItem.Name = "temasToolStripMenuItem";
            temasToolStripMenuItem.Size = new Size(224, 26);
            temasToolStripMenuItem.Text = "Temas";
            temasToolStripMenuItem.Click += temasMenuItem_Click;
            // 
            // festasMenuItem
            // 
            festasMenuItem.Name = "festasMenuItem";
            festasMenuItem.Size = new Size(224, 26);
            festasMenuItem.Text = "Festas";
            festasMenuItem.Click += festasMenuItem_Click;
            // 
            // aluguéisToolStripMenuItem
            // 
            aluguéisToolStripMenuItem.Name = "aluguéisToolStripMenuItem";
            aluguéisToolStripMenuItem.Size = new Size(224, 26);
            aluguéisToolStripMenuItem.Text = "Aluguéis";
            aluguéisToolStripMenuItem.Click += AluguelMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnDeletar, toolStripSeparator1, tslTipoCadastros });
            toolStrip1.Location = new Point(0, 30);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1026, 45);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Enabled = false;
            btnInserir.Image = Properties.Resources.addIcon;
            btnInserir.ImageScaling = ToolStripItemImageScaling.None;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(7);
            btnInserir.Size = new Size(42, 42);
            btnInserir.Text = "toolStripButton1";
            btnInserir.ToolTipText = "Inserir";
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = Properties.Resources.editIcon;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(7);
            btnEditar.Size = new Size(42, 42);
            btnEditar.Text = "toolStripButton1";
            btnEditar.ToolTipText = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDeletar.Enabled = false;
            btnDeletar.Image = Properties.Resources.deleteIcon;
            btnDeletar.ImageScaling = ToolStripItemImageScaling.None;
            btnDeletar.ImageTransparentColor = Color.Magenta;
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Padding = new Padding(7);
            btnDeletar.Size = new Size(42, 42);
            btnDeletar.Text = "toolStripButton1";
            btnDeletar.ToolTipText = "Deletar";
            btnDeletar.Click += btnDeletar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 45);
            // 
            // tslTipoCadastros
            // 
            tslTipoCadastros.Name = "tslTipoCadastros";
            tslTipoCadastros.Size = new Size(114, 42);
            tslTipoCadastros.Text = "Tipos Cadastros";
            // 
            // panelRegistros
            // 
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 75);
            panelRegistros.Margin = new Padding(3, 4, 3, 4);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(1026, 500);
            panelRegistros.TabIndex = 3;
            // 
            // temporizador
            // 
            temporizador.Interval = 1000;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 601);
            Controls.Add(panelRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(826, 648);
            Name = "TelaPrincipalForm";
            Text = "PartyManager1.0";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosMenuItem;
        private ToolStripMenuItem clientesMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnDeletar;
        private ToolStripLabel tslTipoCadastros;
        private ToolStripStatusLabel tssStatus;
        private Panel panelRegistros;
        private System.Windows.Forms.Timer temporizador;
        private ToolStripMenuItem temasToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem festasMenuItem;
        private ToolStripMenuItem aluguéisToolStripMenuItem;
    }
}