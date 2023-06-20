namespace PartyManager.WinApp.Compartilhado
{
     public abstract class ControladorBase
     {
          public abstract string ToolTipInserir { get; }
          public abstract string ToolTipEditar { get; }
          public abstract string ToolTipDeletar { get; }
          public virtual string ToolTipFiltrar { get; }
          public virtual string ToolTipVisualizarHistorico { get; }

          public virtual bool InserirHabilitado { get { return true; } }
          public virtual bool EditarHabilitado { get { return true; } }
          public virtual bool DeletarHabilitado { get { return true; } }
          public virtual bool FiltrarHabilitado { get { return false; } }
          public virtual bool VisualizarHistoricoHabilitado { get { return false; } }



          public abstract void Inserir();

          public abstract void Editar();

          public abstract void Deletar();

          public virtual void Filtrar()
          {
          }

          public virtual void VisualizarHistorico()
          {
          }

          public abstract UserControl ObterListagem();

          public abstract string ObterTipoCadastro();
     }
}
