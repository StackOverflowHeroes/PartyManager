
using PartyManager.Dominio.ModuloAluguel;
using PartyManager.Dominio.ModuloCliente;
using PartyManager.Dominio.ModuloFesta;
using PartyManager.WinApp.ModuloCliente;

namespace PartyManager.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        private IRepositorioAluguel repoAluguel;
        private IRepositorioFesta repoFesta;
        private IRepositorioCliente repoCliente;
        private TabelaAluguelControl tabelaAluguel;

        public ControladorAluguel(IRepositorioAluguel repositorioAluguel, IRepositorioFesta repositorioFesta, IRepositorioCliente repositorioCliente)
        {
            repoAluguel = repositorioAluguel;
            repoFesta = repositorioFesta;
            repoCliente = repositorioCliente;
        }

        public override string ToolTipInserir => "Inserir um novo aluguel";

        public override string ToolTipEditar => "Editar um aluguel existente";

        public override string ToolTipDeletar => "Excluir um aluguel existente";

        public override void Deletar()
        {
            throw new NotImplementedException();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            List<Cliente> ListaCompletaCliente = repoCliente.SelecionarTodos();
            List<Festa> ListaCompletaFesta = repoFesta.SelecionarTodos();

            TelaAluguelForm telaAluguel = new TelaAluguelForm();
            telaAluguel.PopularComboBox(ListaCompletaCliente, ListaCompletaFesta);

            if (telaAluguel.ShowDialog() == DialogResult.OK)
            {
                Aluguel aluguel = telaAluguel.ObterAluguel();
                aluguel.CalcularValorPagamento();
                repoAluguel.Inserir(aluguel);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Aluguel inserido com sucesso!", TipoStatusEnum.Sucesso);
            }

            CarregarAlugueis();

        }

        private Aluguel ObterClienteSelecionado()
        {
            int id = tabelaAluguel.ObterIdSelecionado();
            return repoAluguel.SelecionarPorId(id);
        }

        public void CarregarAlugueis()
        {
            List<Aluguel> alugueis = repoAluguel.SelecionarTodos();

            tabelaAluguel.AtualizarRegistros(alugueis);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaAluguel == null)
                tabelaAluguel = new TabelaAluguelControl();

            CarregarAlugueis();

            return tabelaAluguel;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastros de Aluguéis";
        }
    }
}
