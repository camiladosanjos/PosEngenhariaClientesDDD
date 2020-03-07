using ClientesDDD.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientesDDD.Dominio.Entidades
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
