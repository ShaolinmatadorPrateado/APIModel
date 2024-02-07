﻿using APIModel.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIModel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpGet("GetPessoa")]
        public Pessoa GetPessoa()
        {
            Pessoa vPessoa = new Pessoa();
            vPessoa.Id = 1;
            vPessoa.Nome = "José das Couves";
            vPessoa.Celular = "(18) 98569-6547";

            return vPessoa;
        }

        [HttpGet("GetPessoas")]
        public List<Pessoa> GetPessoas()
        {
            var vPessoa = new Pessoa();


            return vPessoa.Dados();
        }
    }
}
