using System.Reflection.Metadata.Ecma335;
using PartyManager.Dominio.ModuloItens;

namespace PartyManager.Dominio.ModuloTema
{
    public class Tema : EntidadeBase<Tema>
    {
        public string nome { get; set; }
        public List<Item> ListaItens = new List<Item>();
        public decimal valorTotalItens;

        public Tema()
        {
        }

        public override string? ToString()
        {
            return $"Nome: {nome}";
        }

        public Tema(int id, string nome, List<Item> ListaCompletaItens)
        {
            this.id = id;
            this.nome = nome;
            this.ListaItens = ListaCompletaItens;
        }

        public override void AtualizarRegistros(Tema registroAtualizado)
        {
            nome = registroAtualizado.nome;

            ListaItens.Clear();
            valorTotalItens = 0;

            foreach(Item registro in registroAtualizado.ListaItens)
            {
                ListaItens.Add(registro);

                if (registro.statusItem == true)
                    valorTotalItens += registro.valor;
            }
        }

        public void CalcularPrecoTotal()
        {
            foreach(Item registro in ListaItens)
            {
                if (registro.statusItem == true)
                    valorTotalItens += registro.valor;
            }
        }

        public override string[] ValidarErros()
        {
            List<string> ErrosTema = new List<string>();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
                ErrosTema.Add("O nome é obrigatório");

            if (nome.Length < 5)
                ErrosTema.Add("O nome deve conter no mínimo 5 caracteres");

            int ItensSelecionados = ListaItens.Count(item => item.statusItem == true);

            if (ItensSelecionados == 0)
                ErrosTema.Add("O tema deve ter pelo menos um item");

            return ErrosTema.ToArray();
        }
    }
}
