

using PartyManager.Dominio.ModuloAluguel;

namespace PartyManager.WinApp.ModuloAluguel
{
    public partial class TelaFiltroAlugueisForm : Form
    {
        private StatusFiltroAlugueisEnum statusFiltro;

        public TelaFiltroAlugueisForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public StatusFiltroAlugueisEnum ObterStatusFiltro()
        {
            return statusFiltro;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (RadioButtonPendentes.Checked)
                statusFiltro = StatusFiltroAlugueisEnum.Pendentes;
            else if (RadioButtonConcluidos.Checked)
                statusFiltro = StatusFiltroAlugueisEnum.Concluidos;
            else
                statusFiltro = StatusFiltroAlugueisEnum.Todos;
        }
    }
}
