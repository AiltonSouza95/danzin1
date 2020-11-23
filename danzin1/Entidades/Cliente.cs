using System;
using System.Collections.Generic;
using System.Text;

namespace ExEnumEComp.Entities
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Nasc { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome, string email, DateTime nasc)
        {
            Nome = nome;
            Email = email;
            Nasc = nasc;
        }

        public override string ToString()
        {
            return Nome
                + ", ("
                + Nasc.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}
    