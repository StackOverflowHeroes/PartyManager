using PartyManager.Dados.Arquivo.ModuloAluguel;
using PartyManager.Dados.Arquivo.ModuloCliente;
using PartyManager.Dados.Arquivo.ModuloFesta;
using PartyManager.Dados.Arquivo.ModuloItens;
using PartyManager.Dados.Arquivo.ModuloTema;
using PartyManager.Dominio.ModuloAluguel;
using PartyManager.Dominio.ModuloCliente;
using PartyManager.Dominio.ModuloFesta;
using PartyManager.Dominio.ModuloItens;
using PartyManager.Dominio.ModuloTema;
using PartyManager.WinApp.ModuloAluguel;
using PartyManager.WinApp.ModuloCliente;
using PartyManager.WinApp.ModuloFesta;
using PartyManager.WinApp.ModuloItens;
using PartyManager.WinApp.ModuloTema;

namespace PartyManager.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private int contadorTemporizador = 5;
        private ControladorBase controlador;
        private static ContextoDados contexto = new ContextoDados(carregarDados: true);
        private IRepositorioCliente repositorioCliente = new RepositorioClienteArquivo(contexto);
        private IRepositorioTema repositorioTema = new RepositorioTemaArquivo(contexto);
        private IRepositorioFesta repositorioFesta = new RepositorioFestaArquivo(contexto);
        private IRepositorioAluguel repositorioAluguel = new RepositorioAluguelArquivo(contexto);
        private IRepositorioItem repositorioItem = new RepositorioItensArquivo(contexto);

        private static TelaPrincipalForm telaPrincipal;

        public static TelaPrincipalForm Instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipalForm();

                return telaPrincipal;
            }
        }

        public TelaPrincipalForm()
        {
            InitializeComponent();
            temporizador.Interval = 1000;
            temporizador.Tick += Timer_tick;
            telaPrincipal = this;
        }

        public void AtualizarRodape(string mensagem, TipoStatusEnum tipoStatus)
        {
            contadorTemporizador = 5;
            Color cor = default;
            switch (tipoStatus)
            {
                case TipoStatusEnum.Nenhum: break;
                case TipoStatusEnum.Erro: cor = Color.Red; break;
                case TipoStatusEnum.Sucesso: cor = Color.Green; break;
                case TipoStatusEnum.Visualizando: cor = Color.Blue; break;
            }

            tssStatus.ForeColor = cor;
            tssStatus.Text = mensagem;

            if (tipoStatus != TipoStatusEnum.Visualizando)
                temporizador.Start();
        }

        private void Timer_tick(object? sender, EventArgs e)
        {
            contadorTemporizador--;

            if (contadorTemporizador == 0)
            {
                tssStatus.ForeColor = default;
                tssStatus.Text = "Status";
                temporizador.Stop();
            }
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnDeletar.ToolTipText = controlador.ToolTipDeletar;
            btnFiltrar.ToolTipText = controlador.ToolTipFiltrar;
        }

        private void ConfigurarListas(ControladorBase controladorBase)
        {
            UserControl listas = controladorBase.ObterListagem();
            listas.Dock = DockStyle.Fill;
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listas);
        }

        private void ConfigurarBarraFerramentas(ControladorBase controlador)
        {
            toolStrip1.Enabled = true;
            ConfigurarToolTips(controlador);
            ConfigurarEstadosBotoes(controlador);
        }

        private void ConfigurarEstadosBotoes(ControladorBase controlador)
        {
            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnDeletar.Enabled = controlador.DeletarHabilitado;
            btnFiltrar.Enabled = controlador.FiltrarHabilitado;
            btnHistorico.Enabled = controlador.VisualizarHistoricoHabilitado;
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            tslTipoCadastros.Text = controlador.ObterTipoCadastro();
            ConfigurarBarraFerramentas(controladorBase);
            ConfigurarListas(controladorBase);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            controlador.Deletar();
        }
        private void btnHistorico_Click(object sender, EventArgs e)
        {
            controlador.VisualizarHistorico();
        }

        private void clientesMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCliente(repositorioCliente);
            btnHistorico.Enabled = controlador.VisualizarHistoricoHabilitado;
            ConfigurarTelaPrincipal(controlador);
        }

        private void temasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTema(repositorioTema, repositorioItem, repositorioAluguel);
            ConfigurarTelaPrincipal(controlador);
        }

        private void festasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorFesta(repositorioFesta, repositorioCliente, repositorioTema);
            ConfigurarTelaPrincipal(controlador);
        }

        private void AluguelMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorAluguel(repositorioAluguel, repositorioFesta, repositorioCliente);
            ConfigurarTelaPrincipal(controlador);
        }

        private void itensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorItens(repositorioItem, repositorioTema);
            ConfigurarTelaPrincipal(controlador);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            controlador.Filtrar();
        }
    }
}