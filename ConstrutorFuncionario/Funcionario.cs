using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorFuncionario
{
    public class Funcionario
    {
        //declaração dos atributos de forma implicita
        //declaração da propriedade com os métodos de encapsulamento get e set
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public double Salario { get; set; }
        public static int Contador { get; private set; }

        //declaração do construtor - atalho ctor
        //inicializa os atributos da classe
        //ctor - construtor
        /*public Funcionario(Parameters)
        {

        }*/

        public Funcionario()
        {
            Contador += 1;
        }

        public Funcionario(int codigo)
        {
            Codigo = codigo;
            Contador += 1;
        }
        public Funcionario(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            Contador += 1;
        }

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            Contador += 1;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Cód. do Func." + Codigo + "\tNome do Func." + Nome + "\tSalário do Func." + Salario);
        }


    }
}