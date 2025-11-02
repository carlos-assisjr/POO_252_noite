using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Comprador
    {
        public double Verba { get; set; }
        public Comprador(double verba)
        {
            Verba = verba;
        }
        public void MostrarAtributo()
        {
            Console.WriteLine($"A verba do comprador é {Verba:C}");
        }
    }
}