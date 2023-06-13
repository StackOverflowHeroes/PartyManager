using System.Text.Json.Serialization;

namespace PartyManager.Dominio.ModuloCliente
{
     public class Cliente : EntidadeBase<Cliente>
     {
          public string nome { get; set; }
          public string telefone;
          public int contadorFesta = 0;
          public Cliente()
          {

          }
          public Cliente(int id, string nome, string telefone)
          {
               this.id = id;
               this.nome = nome;
               this.telefone = telefone;
          }

          public override void AtualizarRegistros(Cliente registroAtualizado)
          {
               nome = registroAtualizado.nome;
               telefone = registroAtualizado.telefone;
          }

          public override string[] ValidarErros()
          {
               List<string> erros = new List<string>();

               if (string.IsNullOrEmpty(nome))
                    erros.Add("Campo \"Nome\" é obrigatório!");

               if (telefone == "(  )     -")
                    erros.Add("Campo \"Telefone\"é obrigatório!");

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
