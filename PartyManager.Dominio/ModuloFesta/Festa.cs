using PartyManager.Dominio.ModuloCliente;
using PartyManager.Dominio.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyManager.Dominio.ModuloFesta
{
    public class Festa : EntidadeBase<Festa>
    {
        public string endereco;

        public Cliente cliente;
        public Tema tema;

        public DateTime data;
        public TimeSpan horaInicio;
        public TimeSpan horaTermino;

        public Festa()
        {

        }

        public Festa(int id, string endereco, Tema tema, Cliente cliente, DateTime data, TimeSpan horaInicio, TimeSpan horaTermino)
        {
            this.id = id;
            this.endereco = endereco;
            this.cliente = cliente;
            this.tema = tema;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaTermino = horaTermino;
        }
        public Festa(string endereco, Cliente cliente, Tema tema, DateTime data, TimeSpan horaInicio, TimeSpan horaTermino)
        {
            this.endereco = endereco;
            this.cliente = cliente;
            this.tema = tema;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaTermino = horaTermino;
        }



        public override void AtualizarRegistros(Festa registroAtualizado)
        {
            endereco = registroAtualizado.endereco;
            tema = registroAtualizado.tema;
            cliente = registroAtualizado.cliente;
            data = registroAtualizado.data;
            horaInicio = registroAtualizado.horaInicio;
            horaTermino = registroAtualizado.horaTermino;
        }

        public override string[] ValidarErros()
        {
            List<string> errosFesta = new List<string>();

            if (cliente == null) 
            {
                errosFesta.Add("Campo \"Cliente\" é obrigatório!");
            }
            if (tema == null)
            {
                errosFesta.Add("Campo \"Tema\" é obrigatório!");
            }

            if (string.IsNullOrEmpty(endereco))
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
                    horaInicio.Equals(festa.horaInicio) &&
                    horaTermino.Equals(festa.horaTermino) &&
                    EqualityComparer<Cliente>.Default.Equals(cliente, festa.cliente) &&
                    EqualityComparer<Tema>.Default.Equals(tema, festa.tema);
        }
    }
}
