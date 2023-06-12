using PartyManager.Dominio.ModuloCliente;

namespace PartyManager.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        private IRepositorioCliente repoCliente;
        private TabelaClienteControl tabelaCliente;

        public ControladorCliente(IRepositorioCliente repoCliente)
        {
            this.repoCliente = repoCliente;
        }

        public override string ToolTipInserir => "Inserir Cliente";

        public override string ToolTipEditar => "Editar Cliente";

        public override string ToolTipDeletar => "Deletar Cliente";

        public override void Deletar()
        {
            Cliente cliente = ObterClienteSelecionado();

            if (cliente == null)
            {
                MessageBox.Show($"Selecione um cliente primeiro!",
                    "Exclusão de Clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o cliente {cliente.nome}?", "Exclusão de Clientes",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repoCliente.Deletar(cliente);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Cliente deletado com sucesso!", TipoStatusEnum.Sucesso);
            }

            CarregarClientes();
            
        }

        private Cliente ObterClienteSelecionado()
        {
            int id = tabelaCliente.ObterIdSelecionado();
            return repoCliente.SelecionarPorId(id);
        }

        public override void Editar()
        {
            Cliente cliente = ObterClienteSelecionado();

            if (cliente == null)
            {
                MessageBox.Show($"Selecione um cliente primeiro!",
                    "Edição de Clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaClienteForm telaCliente = new TelaClienteForm();
            telaCliente.ConfigurarTela(cliente);

            DialogResult opcaoEscolhida = telaCliente.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Cliente clienteAtualizado = telaCliente.ObterCliente();
                repoCliente.Editar(clienteAtualizado.id, clienteAtualizado);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Cliente editado com sucesso!", TipoStatusEnum.Sucesso);
            }

            CarregarClientes();
            
        }

        public override void Inserir()
        {
            TelaClienteForm telaCliente = new TelaClienteForm();

            DialogResult opcaoEscolhida = telaCliente.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Cliente cliente = telaCliente.ObterCliente();
                repoCliente.Inserir(cliente);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Cliente inserido com sucesso!", TipoStatusEnum.Sucesso);
            }

            CarregarClientes();
            
        }

        private void CarregarClientes()
        {
            List<Cliente> clientes = repoCliente.SelecionarTodos();

            tabelaCliente.AtualizarRegistros(clientes);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCliente == null)
                tabelaCliente = new TabelaClienteControl();

            CarregarClientes();

            return tabelaCliente;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastros de Clientes";
        }
    }
}
