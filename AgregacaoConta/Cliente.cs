using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Cliente
    {
        public string? Nome { get; set; }
        public int Rg { get; set; }

        public void Mostrar()
        {
            Console.WriteLine($"Nome: {Nome} \t Rg: {Rg}");
        }
    }
}