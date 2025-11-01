using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public class ClienteJuridico : Cliente
    {
        public int Cnpj{get; set; }
        public ClienteFisico(int codigo, string nome, int idade, int cnpj)
         : base(codigo, nome, idade)
        {
            Cnpj = cnpj;
        }
        public override void Mostrar()
        {
            // a palavra base. chama o metodo da superclasse
            base.Mostrar();
            Console.WriteLine("Cnpj: "+ Cnpj);
        }
        public override void VerifiqueIdade(){
            if (Idade > 45)
                System.Console.WriteLine("Cliete Jurídico!");
        }
    }
}