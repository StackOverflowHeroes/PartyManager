using PartyManager.Dominio.ModuloCliente;
using PartyManager.Dominio.ModuloTema;

namespace PartyManager.Dominio.ModuloFesta
{
    public class Festa : EntidadeBase<Festa>
    {
        public string endereco;

        public Cliente cliente { get; set; }
        public Tema tema;
        public string nome;
        public DateTime data;
        public TimeSpan horaInicio;
        public TimeSpan horaTermino;

        public Festa()
        {

        }

        public Festa(int id, string endereco, Tema tema, Cliente cliente, DateTime data, TimeSpan horaInicio, TimeSpan horaTermino, string nome)
        {
            this.id = id;
            this.endereco = endereco;
            this.cliente = cliente;
            this.tema = tema;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaTermino = horaTermino;
            this.nome = nome;
        }

        public override string? ToString()
        {
            return nome;
        }

        public override void AtualizarRegistros(Festa registroAtualizado)
        {
            endereco = registroAtualizado.endereco;
            tema = registroAtualizado.tema;
            cliente = registroAtualizado.cliente;
            data = registroAtualizado.data;
            horaInicio = registroAtualizado.horaInicio;
            horaTermino = registroAtualizado.horaTermino;
            nome = registroAtualizado.nome;
        }

        public override string[] ValidarErros()
        {
            List<string> errosFesta = new List<string>();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
                errosFesta.Add("Campo \"Nome\" é obrigatório!");

               if (cliente == null) 
            {
                errosFesta.Add("Campo \"Cliente\" é obrigatório!");
            }
            if (tema == null)
            {
                errosFesta.Add("Campo \"Tema\" é obrigatório!");
            }

            if (string.IsNullOrEmpty(endereco) || string.IsNullOrWhiteSpace(nome))
                errosFesta.Add("Campo \"Endereço\" é obrigatório!");

            if (data < DateTime.Now)
            {
                errosFesta.Add("Campo \"Data\" não pode ser anterior a data atual!");
            }
            if (horaTermino <= horaInicio)
            {
                errosFesta.Add("Campo \"Hora Término\" deve ser superior ao horário de início!");
            }

            return errosFesta.ToArray();
        }
        public override bool Equals(object? obj)
        {
            return obj is Festa festa &&
                    id == festa.id &&
                    endereco == festa.endereco &&
                    tema == festa.tema &&
                    cliente == festa.cliente &&
                    data == festa.data &&
                    nome == festa.nome &&
                    horaInicio.Equals(festa.horaInicio) &&
                    horaTermino.Equals(festa.horaTermino) &&
                    EqualityComparer<Cliente>.Default.Equals(cliente, festa.cliente) &&
                    EqualityComparer<Tema>.Default.Equals(tema, festa.tema);
        }
    }
}
