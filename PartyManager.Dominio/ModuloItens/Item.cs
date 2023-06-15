namespace PartyManager.Dominio.ModuloItens
{
    public class Item : EntidadeBase<Item>
    {
        public string nome;
        public decimal valor;
        public bool statusItem;

        public Item()
        {
        }

        public Item(int id, string nome, decimal valor)
        {
            this.id = id;
            this.nome = nome;
            this.valor = valor;
        }

        public override string? ToString()
        {
            return $"NOME: {nome.ToUpper()}, VALOR: R$: {valor}";
        }

        public override void AtualizarRegistros(Item registroAtualizado)
        {
            nome = registroAtualizado.nome;
            valor = registroAtualizado.valor;
        }

        public override string[] ValidarErros()
        {
            List<string> ErrosItens = new List<string>();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
                ErrosItens.Add("O campo nome é obrigatório");

            if (valor < 0)
                ErrosItens.Add("O valor tem que ser ZERO ou MAIOR QUE ZERO");


            return ErrosItens.ToArray();
        }

        public void MarcarComoSelecionado()
        {
            statusItem = true;
        }

        public void MarcarComoNaoSelecionado()
        {
            statusItem = false;
        }
    }
}
