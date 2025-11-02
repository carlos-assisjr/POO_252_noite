using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Perecivel : Produto
    {
        private string? dataFabricacao;
        private string? dataValidade;
        private int lote;
        public string? DataFabricacao
        {
            get { return dataFabricacao; }
            set { dataFabricacao = value; }
        }

        public string? DataValidade
        {
            get { return dataValidade; }
            set { dataValidade = value; }
        }

        public int Lote
        {
            get { return lote; }
            set { lote = value; }
        }
        public override void Mostrar()
        {
            base.Mostrar();//apresente código, nome e preço
            Console.WriteLine($"Data de Fabricação: {DataFabricacao}\tData de Validade: {DataValidade}\tLote: {Lote}");
            Console.WriteLine("-----------------------------------------------");
        }
        
    }
}