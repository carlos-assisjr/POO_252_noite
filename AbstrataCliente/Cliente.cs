using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public abstract class Cliente
    {
        protected int codigo;
        protected string? nome;
        protected int? idade;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public virtual void Mostrar()
        {
            Console.WriteLine("Codigo" + Codigo + "\tNome" + Nome +
             "\tIdade" + Idade);
        }

        public Cliente(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }
    }
}