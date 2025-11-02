using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Vendedor
    {
        public double Comissao { get; set; }
        public void MostrarAtributo()
        {
            Console.WriteLine($"Comissão de venda R$ {Comissao:C}");
        }
        public Vendedor()
        {
            Comissao = 0;
        }
        
    }
}