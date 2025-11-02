using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoComposicaoBanco
{
    public class Poupanca
    {
        private double saldo;
        public double Saldo
        {
            get { return saldo; }
            private set
            {
                if (value >= 0)
                    saldo = value;
            }
        }

        public Poupanca(double saldoInicial)
        {
            Saldo = saldoInicial;
            Console.WriteLine($"Poupança criada com saldo inicial de {Saldo:C}.");
        }


        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de {valor:C} realizado na Poupança. Saldo atual: {Saldo:C}.");
            }
            else
            {
                Console.WriteLine("O valor do depósito deve ser positivo.");
            }
        }

        public bool Sacar(double valor)
        {
            if (valor > 0 && Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado na Poupança. Saldo atual: {Saldo:C}.");
                return true;
            }
            else if (valor <= 0)
            {
                Console.WriteLine("O valor do saque deve ser positivo.");
                return false;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente na Poupança para realizar o saque.");
                return false;
            }
        }

        public void GerarRendimento(double taxa)
        {
            if (taxa > 0)
            {
                double rendimento = Saldo * taxa;
                Saldo += rendimento;
                Console.WriteLine($"Rendimento de {rendimento:C} (Taxa: {taxa:P}) creditado na Poupança. Saldo atual: {Saldo:C}.");
            }
            else
            {
                Console.WriteLine("A taxa de rendimento deve ser positiva.");
            }
        }
        ~Poupanca()
        {
            Console.WriteLine($"Poupança (Hash: {this.GetHashCode()}) foi encerrada.");
        }
    }
}