using PartyManager.Dominio.ModuloAluguel;

namespace PartyManager.Dominio.ModuloCliente
{
     public class Cliente : EntidadeBase<Cliente>
     {
          
          public string nome { get; set; }
          public string telefone;
          public int contadorFesta = 0;
          public List<Aluguel> alugueis;
          private decimal desconto;
          public Cliente()
          {

          }
          public Cliente(int id, string nome, string telefone)
          {
               this.id = id;
               this.nome = nome;
               this.telefone = telefone;
               alugueis = new List<Aluguel>();
          }

          public decimal Desconto
          {
               get { return desconto; }
          }

        public override void AtualizarRegistros(Cliente registroAtualizado)
          {
               nome = registroAtualizado.nome;
               telefone = registroAtualizado.telefone;
               alugueis = registroAtualizado.alugueis;
          }

        public decimal CalcularDescontoCliente()
        {
               switch (contadorFesta)
               {
                    case 1: desconto = 1; break;
                    case 2: desconto = 0.95m; break;
                    case 3: desconto = 0.90m; break;
                    case 4: desconto = 0.85m; break;
                    default: desconto = 0.80m; break;
               }

               return desconto;
        }

        public void AumentarContagemFestas()
        {
               contadorFesta++;
        }

        public override string[] ValidarErros()
          {
               List<string> erros = new List<string>();

               if (string.IsNullOrEmpty(nome))
                    erros.Add("Campo \"Nome\" é obrigatório!");

               if (telefone == "(  )     -")
                    erros.Add("Campo \"Telefone\"é obrigatório!");

               if (nome.Length < 5)
                    erros.Add("Campo \"Nome\"deve conter cinco ou mais letras!");

               return erros.ToArray();
          }

        public override string? ToString()
        {
            return $"Nome: {nome}, telefone: {telefone}";
        }

        public override bool Equals(object? obj)
          {
               return obj is Cliente cliente &&
                      id == cliente.id &&
                      nome == cliente.nome &&
                      telefone == cliente.telefone &&
                      contadorFesta == cliente.contadorFesta;
          }
     }
}
