using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoComposicaoBanco
{
    public class ContaCorrente
    {
        private double saldo;
        public double Saldo
        {
            get { return saldo; }
            private set
            {
                saldo = value;
            }
        }

        private double chequeEspecial;
        public double ChequeEspecial
        {
            get { return chequeEspecial; }
            private set
            {
                if (value >= 0)
                    chequeEspecial = value;
            }
        }

        public ContaCorrente(double saldoInicial, double limiteCheque)
        {
            Saldo = saldoInicial;
            ChequeEspecial = limiteCheque;
            Console.WriteLine($"Conta Corrente criada. Saldo: {Saldo:C}, Limite Ch. Especial: {ChequeEspecial:C}.");
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de {valor:C} realizado na CC. Saldo atual: {Saldo:C}.");
            }
            else
            {
                Console.WriteLine("O valor do depósito deve ser positivo.");
            }
        }

        public bool Sacar(double valor)
        {
            double limiteTotal = Saldo + ChequeEspecial;

            if (valor > 0 && limiteTotal >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado na CC. Novo Saldo: {Saldo:C}.");
                return true;
            }
            else if (valor <= 0)
            {
                Console.WriteLine("O valor do saque deve ser positivo.");
                return false;
            }
            else
            {
                Console.WriteLine("Limite total (Saldo + Cheque Especial) insuficiente para o saque.");
                return false;
            }
        }

        public void GerarExtrato()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"EXTRATO - Conta Corrente");
            Console.WriteLine($"Saldo Atual: {Saldo:C}");
            Console.WriteLine($"Limite Cheque Especial: {ChequeEspecial:C}");
            double disponivel = Saldo + ChequeEspecial;
            Console.WriteLine($"Total Disponível (com Cheque): {disponivel:C}");
            Console.WriteLine("------------------------------------------");
        }
        ~ContaCorrente()
        {
            Console.WriteLine($"Conta Corrente (Hash: {this.GetHashCode()}) foi encerrada.");
        }
    }
}