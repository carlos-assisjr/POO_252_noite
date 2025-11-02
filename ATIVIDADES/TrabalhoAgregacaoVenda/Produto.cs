using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Produto
    {
        public int Codigo { get; private set; }
        private static int Contador;
        private string? nome;
        public string? Nome
        {
            get { return nome; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nome = value; // Atribui o novo valor se ele for válido
                }
                else
                {
                    Console.WriteLine("O nome do produto não pode ser nulo ou vazio.");
                }
            }
        }

        private double preco;
        public double Preco
        {
            get { return preco; }
            set
            {
                if (value > 0)
                {
                    preco = value;
                }
                else
                {
                    Console.WriteLine("O preço deve ser maior que R$0,00");
                    return;
                }
            }
        }


        static Produto()
        {
            Contador = 500;
        }
        public Produto(string? nome, double preco)
        {
            Codigo = Contador;
            Contador++;
            Nome = nome;
            Preco = preco;
        }
        public void MostrarAtributo()
        {
            Console.WriteLine("Código:" + Codigo + "\tNome:" + Nome + "\tPreço:" + Preco);
        }
    }
}