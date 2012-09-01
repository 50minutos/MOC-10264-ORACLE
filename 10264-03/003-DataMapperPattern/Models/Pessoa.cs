using System;
using System.Collections.Generic;

namespace _003_DataMapperPattern.Models
{
    public class Pessoa
    {
        public int Codigo { get; set; }
        public String Nome { get; set; }
        public char Sexo { get; set; }
    }

    public class PessoaMapper
    {
        public void Insert(Pessoa p)
        {
            //sua lógica vai aqui!!!
        }

        public void Update(Pessoa p)
        {
            //sua lógica vai aqui!!!
        }

        public void Delete(Pessoa p)
        {
            //sua lógica vai aqui!!!
        }

        public List<Pessoa> Get(int codigo)
        {
            var retorno = new List<Pessoa>();

            //sua lógica vai aqui!!!

            return retorno;
        }
    }
}