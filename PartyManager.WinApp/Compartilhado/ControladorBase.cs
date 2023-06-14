namespace PartyManager.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }
        public abstract string ToolTipEditar { get; }
        public abstract string ToolTipDeletar { get; }

        public virtual bool InserirHabilitado { get { return true; } }
        public virtual bool EditarHabilitado { get { return true; } }
        public virtual bool DeletarHabilitado { get { return true; } }

        public abstract void Inserir();

        public abstract void Editar();

        public abstract void Deletar();

        public abstract UserControl ObterListagem();

        public abstract string ObterTipoCadastro();
    }
}
