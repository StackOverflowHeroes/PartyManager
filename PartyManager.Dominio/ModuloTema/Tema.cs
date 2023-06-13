
namespace PartyManager.Dominio.ModuloTema
{
    public class Tema : EntidadeBase<Tema>
    {
        public string nome;
        public List<Item> ListaItens = new List<Item>();
        public decimal valorTotalItens;

        public Tema()
        {
        }

        public override string? ToString()
        {
            return $"Nome: {nome}";
        }

        public Tema(int id, string nome, List<Item> listaItens)
        {
            this.id = id;
            this.nome = nome;
            this.ListaItens = listaItens;
        }

        public override void AtualizarRegistros(Tema registroAtualizado)
        {
            nome = registroAtualizado.nome;

            ListaItens.Clear();
            valorTotalItens = 0;

            foreach(Item registro in registroAtualizado.ListaItens)
            {
                ListaItens.Add(registro);
                valorTotalItens += registro.valor;
            }
        }

        public void CalcularPrecoTotal()
        {
            foreach(Item itemTema in ListaItens)
            {
                valorTotalItens += itemTema.valor;
            }
        }

        public override string[] ValidarErros()
        {
            List<string> ErrosTema = new List<string>();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
                ErrosTema.Add("O nome é obrigatório");

            if (ListaItens.Count == 0)
                ErrosTema.Add("O tema deve ter pelo menos um item");

            return ErrosTema.ToArray();
        }
    }
}
