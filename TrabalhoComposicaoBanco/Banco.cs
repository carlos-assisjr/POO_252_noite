using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoComposicaoBanco
{
    public class Banco
    {
        private List<Poupanca> poups;
        private List<ContaCorrente> contas;

        public Banco()
        {
            poups = new List<Poupanca>();
            contas = new List<ContaCorrente>();
            Console.WriteLine("\n*** Banco Inicializado e pronto para abrir contas. ***");
        }

        public ContaCorrente AbrirConta(double saldoInicial, double limiteCheque)
        {
            ContaCorrente novaConta = new ContaCorrente(saldoInicial, limiteCheque);
            contas.Add(novaConta);
            Console.WriteLine($"\nNova Conta Corrente aberta no Banco (Total de Contas: {contas.Count}).");
            return novaConta;
        }

        public Poupanca AbrirPoupanca(double saldoInicial)
        {
            Poupanca novaPoupanca = new Poupanca(saldoInicial);
            poups.Add(novaPoupanca);
            Console.WriteLine($"\nNova Poupança aberta no Banco (Total de Poupanças: {poups.Count}).");
            return novaPoupanca;
        }

        public void DecretarFalencia()
        {
            Console.WriteLine("\n==============================================");
            Console.WriteLine("DECRETANDO A FALÊNCIA DO BANCO!");

            contas.Clear();
            poups.Clear();
            Console.WriteLine("Todas as contas e poupanças foram liquidadas.");
            Console.WriteLine("==============================================");
        }
        ~Banco()
        {
            Console.WriteLine("\n*** Banco encerrado. Todas as contas foram fechadas. ***");
        }
    }
}