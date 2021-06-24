using EFCoreNaPratica.Data;
using EFCoreNaPratica.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreNaPratica.Controllers
{
    public class TesteCrudController : Controller
    {

        private readonly MeuDbContext _contexto;

        //Contexto injetado por dependência.
        public TesteCrudController(MeuDbContext contexto)
        {
            //contexto recebe o valor do "MeuDbContext _contexto"
            _contexto = contexto;
        }
        public IActionResult Index()
        {

            var aluno = new Aluno()
            {
                Nome = "Luan",
                DataNascimento = DateTime.Now,
                Email = "Luan.vendrami@hotmail.com"
            };

            //Adiciona o aluno na memória
            _contexto.Alunos.Add(aluno);
            //Salvando o aluno no banco de dados
            _contexto.SaveChanges();

            //Obter o aluno pela chave primária (Primary Key)
            var aluno2 = _contexto.Alunos.Find(aluno.Id);
            //Obter aluno por qualquer registro da tabela, com o "FirstOrDefault" é apenas um(Só tem um com esse email no caso) e o primeiro.
            var aluno3 = _contexto.Alunos.FirstOrDefault(a => a.Email == "Luan.vendrami@hotmail.com");
            //Usando o "Where" você retorna uma coleção de alunos (Resultado mais de um, ou seja, traga tudo que você achar).
            var aluno4 = _contexto.Alunos.Where(a => a.Nome == "Luan");

            //Atualixar o aluno através do contexto.
            aluno.Nome = "João";
            _contexto.Alunos.Update(aluno);
            _contexto.SaveChanges();

            //Remover aluno através do contexto.
            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();
            return View("_Layout");
        }
    }
}
