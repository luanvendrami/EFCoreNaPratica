using EFCoreNaPratica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreNaPratica.Data
{
    public class MeuDbContext : DbContext
    { 
        public MeuDbContext(DbContextOptions options)
            : base(options)
        {


        }

        //Passando a classe "Aluno" para que no futuro o EFCore possa mapear as entidades no Banco de dados e criar ela no mesmo, para inserir registro.
        public DbSet<Aluno> Alunos { get; set; }
    }
}
