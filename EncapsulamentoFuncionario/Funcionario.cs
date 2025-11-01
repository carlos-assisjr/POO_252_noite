using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario //pasta
{
    public class Funcionario
    {
        //declaração de atributos

        /*private int numero;//atributo
        public int Numero//propriedade
        {
            get { numero; }
            set { numero = value; }
        }*/

        private int codigo;
        private string? nome;
        private double salario;

        public int Codigo
        {
            set
            {
                codigo = value;
            }
            get
            {
                return codigo;
            }
        }
        public string? Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public double Salario
        {
            get
            {
                return salario;
            }
            set
            {
                salario = value;
            }
        }

        //declaração dos métodos
        public void MostrarAtributos()
        {

            Console.WriteLine("Código: " + codigo + "\tNome: " + nome + "\tSalário R$ " + salario);
        }

        public void CalcularAumento()
        {
            //5%
            salario += salario * 5 / 100;
        }
    }
}