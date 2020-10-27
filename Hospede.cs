using System;
using System.Collections.Generic;
using System.Text;

namespace POO_TarefaVetoresHotel
{
    class Hospede
    {
        public string Nome { get; set; }    //Recebe e grava o nome do hóspede
        public string Email { get; set; }   //Recebe e grava o e-mail do hóspede
        public Hospede(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
