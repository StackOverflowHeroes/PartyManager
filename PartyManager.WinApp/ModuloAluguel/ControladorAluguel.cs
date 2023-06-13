
using PartyManager.Dominio.ModuloAluguel;
using PartyManager.Dominio.ModuloCliente;
using PartyManager.WinApp.ModuloCliente;

namespace PartyManager.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        private IRepositorioAluguel repoAluguel;
        private TabelaAluguelControl tabelaAluguel;

        public ControladorAluguel(IRepositorioAluguel repositorioAluguel)
        {
            repoAluguel = repositorioAluguel;
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
            throw new NotImplementedException();
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
