using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreNaPratica.Models
{
    public class Aluno
    {
        //Entidades 
        public Aluno()
        {
            Id = Guid.NewGuid();
        } 
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
