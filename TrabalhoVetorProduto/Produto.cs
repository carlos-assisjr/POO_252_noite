using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//pasta
namespace TrabalhoVetorProduto
{
    public class Produto
    {
        //declaração dos atributos
        public int codigo;
        public string? nome;
        public double preco;
        public int estoque;
        public double subtotal; // não pode digitar

        //declaração dos métodos/funções
        public void MostrarAtributos()
        {
            /*Console.WriteLine("Código: " + codigo + "\tNome: " + nome + "\tPreço R$ " + preco + "\tEstoque: " + estoque + "\tSubtotal R$ " + subtotal);*/
            Console.WriteLine($"Código: {codigo} \tNome: {nome} \tPreço {preco:C} \tEstoque: {estoque} \tSubtotal { subtotal:C}");
        }
        public void CalcularAumento(double porcentagem)
        {
            //aumento por parâmetro
            preco += preco * porcentagem / 100;
            //preco = preco + preco * porcentagem / 100;
        }
        public void RetirarEstoque(int qtde)
        {
            if (estoque >= qtde)
            {
                estoque -= qtde;
            }
            else //condição para que o estoque nunca seja negativo
            {
                estoque = 0;
            }
            //estoque = estoque - qtde;
        }

        public void CalcularSubTotal()
        {
            subtotal = preco * estoque;
        }

    }
}