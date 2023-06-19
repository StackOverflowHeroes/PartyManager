namespace PartyManager.WinApp.ModuloAluguel
{
    partial class TelaFiltroAlugueisForm
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
            RadioButtonConcluidos = new RadioButton();
            RadioButtonPendentes = new RadioButton();
            RadioButtonTodos = new RadioButton();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.None;
            btnCadastrar.BackColor = SystemColors.ButtonHighlight;
            btnCadastrar.DialogResult = DialogResult.OK;
            btnCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(331, 204);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(86, 60);
            btnCadastrar.TabIndex = 20;
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
            btnCancelar.Location = new Point(424, 204);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 60);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // RadioButtonConcluidos
            // 
            RadioButtonConcluidos.AutoSize = true;
            RadioButtonConcluidos.Location = new Point(95, 152);
            RadioButtonConcluidos.Name = "RadioButtonConcluidos";
            RadioButtonConcluidos.Size = new Size(215, 24);
            RadioButtonConcluidos.TabIndex = 22;
            RadioButtonConcluidos.TabStop = true;
            RadioButtonConcluidos.Text = "Mostrar aluguéis concluídos";
            RadioButtonConcluidos.UseVisualStyleBackColor = true;
            // 
            // RadioButtonPendentes
            // 
            RadioButtonPendentes.AutoSize = true;
            RadioButtonPendentes.Location = new Point(95, 106);
            RadioButtonPendentes.Name = "RadioButtonPendentes";
            RadioButtonPendentes.Size = new Size(213, 24);
            RadioButtonPendentes.TabIndex = 23;
            RadioButtonPendentes.TabStop = true;
            RadioButtonPendentes.Text = "Mostrar aluguéis pendentes";
            RadioButtonPendentes.UseVisualStyleBackColor = true;
            // 
            // RadioButtonTodos
            // 
            RadioButtonTodos.AutoSize = true;
            RadioButtonTodos.Location = new Point(95, 63);
            RadioButtonTodos.Name = "RadioButtonTodos";
            RadioButtonTodos.Size = new Size(182, 24);
            RadioButtonTodos.TabIndex = 24;
            RadioButtonTodos.TabStop = true;
            RadioButtonTodos.Text = "Mostrar todos aluguéis";
            RadioButtonTodos.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroAlugueisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 277);
            Controls.Add(RadioButtonTodos);
            Controls.Add(RadioButtonPendentes);
            Controls.Add(RadioButtonConcluidos);
            Controls.Add(btnCadastrar);
            Controls.Add(btnCancelar);
            Name = "TelaFiltroAlugueisForm";
            ShowIcon = false;
            Text = "Filtrar aluguéis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Button btnCancelar;
        private RadioButton RadioButtonConcluidos;
        private RadioButton RadioButtonPendentes;
        private RadioButton RadioButtonTodos;
    }
}