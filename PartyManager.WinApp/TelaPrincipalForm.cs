using PartyManager.Dados.Arquivo.Compartilhado;
using PartyManager.Dados.Arquivo.ModuloCliente;
using PartyManager.Dados.Arquivo.ModuloTema;
using PartyManager.Dominio.ModuloCliente;
using PartyManager.Dominio.ModuloTema;
using PartyManager.WinApp.ModuloCliente;
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

        /*
        Implementar inst�ncias dos repositorios
        */

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

        /// <summary>
        /// Atualiza a mensagem do rodap� da tela principal, modificando sua cor dependendo do tipo da mensagem informada.
        /// </summary>
        /// <param name="mensagem"></param>
        /// <param name="tipoStatus"></param>
        public void AtualizarRodape(string mensagem, TipoStatusEnum tipoStatus)
        {
            contadorTemporizador = 5;
            Color cor = default;
            switch (tipoStatus)
            {
                case TipoStatusEnum.Nenhum: break;
                case TipoStatusEnum.Erro: cor = Color.Red; break;
                case TipoStatusEnum.Sucesso: cor = Color.Green; break;
                case TipoStatusEnum.Visualizando: cor = Color.DarkGray; break;
            }

            tssStatus.ForeColor = cor;
            tssStatus.Text = mensagem;

            if (tipoStatus != TipoStatusEnum.Visualizando)
                temporizador.Start();
        }

        /// <summary>
        /// Define a configura��o padr�o da mensagem do rodap� da tela principal. Controlado por um intervalo de tempo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Define a descri��o de cada bot�o de funcionalidade da tela principal.
        /// </summary>
        /// <param name="controlador"></param>
        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnDeletar.ToolTipText = controlador.ToolTipDeletar;
        }

        /// <summary>
        /// Define a tabela de uma entidade espec�fica, no painel da tela principal.
        /// </summary>
        /// <param name="controladorBase"></param>
        private void ConfigurarListas(ControladorBase controladorBase)
        {
            UserControl listas = controladorBase.ObterListagem();
            listas.Dock = DockStyle.Fill;
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listas);
        }

        /// <summary>
        /// Habilita bot�es e outras configura��es relacionadas.
        /// </summary>
        /// <param name="controlador"></param>
        private void ConfigurarBarraFerramentas(ControladorBase controlador)
        {
            toolStrip1.Enabled = true;
            ConfigurarToolTips(controlador);
            ConfigurarEstadosBotoes(controlador);
        }

        /// <summary>
        /// Habilita bot�es da tela principal.
        /// </summary>
        /// <param name="controlador"></param>
        private void ConfigurarEstadosBotoes(ControladorBase controlador)
        {
            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnDeletar.Enabled = controlador.DeletarHabilitado;
        }

        /// <summary>
        /// Define todas as configura��es da tela principal para a entidade selecionada.
        /// </summary>
        /// <param name="controladorBase"></param>
        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            tslTipoCadastros.Text = controlador.ObterTipoCadastro();
            ConfigurarBarraFerramentas(controladorBase);
            ConfigurarToolTips(controladorBase);
            ConfigurarListas(controladorBase);
        }


        /// <summary>
        /// Chama a fun��o de inserir do reposit�rio do elemento selecionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        /// <summary>
        /// Chama a fun��o de editar do reposit�rio do elemento selecionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        /// <summary>
        /// Chama a fun��o de deletar do reposit�rio do elemento selecionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            controlador.Deletar();
        }


        private void clientesMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCliente(repositorioCliente);
            ConfigurarTelaPrincipal(controlador);
        }

        private void temasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTema(repositorioTema);
            ConfigurarTelaPrincipal(controlador);
        }
    }
}