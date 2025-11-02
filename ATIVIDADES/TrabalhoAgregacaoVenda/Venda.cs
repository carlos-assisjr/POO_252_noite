using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Venda
    {
        private Comprador comprador;
        private Vendedor vendedor;
        private List<Produto> produtosvendidos;
        public Venda(Comprador comprador, Vendedor vendedor)
        {
            this.comprador = comprador;
            this.vendedor = vendedor;
            this.produtosvendidos = new List<Produto>();
        }
        public void Vender(Produto produto)
        {
            if (comprador.Verba >= produto.Preco)
            {
                comprador.Verba = comprador.Verba - produto.Preco;
                vendedor.Comissao = vendedor.Comissao + produto.Preco * 0.02;
                produtosvendidos.Add(produto);
                Console.WriteLine("Produto '" + produto.Nome + "' vendido com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para adquirir '"+produto.Nome+".");
            }
        }
        public void MostrarAtributo()
        {
            Console.WriteLine("\n\tRESUMO DA VENDA\n");
            comprador.MostrarAtributo();
            vendedor.MostrarAtributo();
            Console.WriteLine("Produtos comprados:");
            foreach (Produto produto in produtosvendidos)
            {
                produto.MostrarAtributo();
            }
        }
    }
}