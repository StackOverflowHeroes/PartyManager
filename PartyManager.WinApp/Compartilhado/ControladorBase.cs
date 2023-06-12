namespace PartyManager.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        #region Mudar mensagem botões

        public abstract string ToolTipInserir { get; }
        public abstract string ToolTipEditar { get; }
        public abstract string ToolTipDeletar { get; }

        #endregion

        #region Habilitar ou desabilitar botões

        public virtual bool InserirHabilitado { get { return true; } }
        public virtual bool EditarHabilitado { get { return true; } }
        public virtual bool DeletarHabilitado { get { return true; } }

        #endregion


        /// <summary>
        /// Função utilizada para gravar em uma lista um objeto e seus dados.
        /// </summary>
        public abstract void Inserir();

        /// <summary>
        /// Função utilizada para sobreescrever de uma lista informações de um objeto.
        /// </summary>
        public abstract void Editar();

        /// <summary>
        /// Função utilizada para deletar de uma lista um objeto e suas informações.
        /// </summary>
        public abstract void Deletar();


        /// <summary>
        /// Seleciona o UserControl de uma entidade específica
        /// </summary>
        /// <returns>Um UserControl de uma entidade.</returns>
        public abstract UserControl ObterListagem();

        /// <summary>
        /// Obtém que entidade será cadastrada.
        /// </summary>
        /// <returns>Uma string indicando o nome da entidade a ser cadastrada.</returns>
        public abstract string ObterTipoCadastro();
    }
}
