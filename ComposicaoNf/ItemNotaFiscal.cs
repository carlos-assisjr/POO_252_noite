using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNf
{
    public class ItemNotaFiscal
    {
        public int QtdeProduto { get; set; }
        public ItemNotaFiscal(int qtdeProduto)
        {
            QtdeProduto = qtdeProduto;
        }

        ~ItemNotaFiscal()// destrutor da classe
        {
            Console.WriteLine("Destruindo o Item nota fiscal");
        }
        public void Mostrar()
        {
            Console.WriteLine("Quantidade de produto: " + QtdeProduto);
        }
    }
}