using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAula29_63.model
{
    internal class Cliente
    {
        public long Id { get; set; }
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public int Telefone { get; set; }
        public string Endereco { get; set; }

        Cliente(long id, string nome, string sobrenome, int telefone, string endereco)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Telefone = telefone;
            this.Endereco = endereco;
        }



        public void cadastrarCliente(long id, string nome, string sobrenome, int telefone, string endereco)
        {
            //List<Cliente> clientes = new List<Cliente>();
            //clientes.Add()


        }

    }
}
