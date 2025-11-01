using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoEstudante
{
    public class Estudante
    {
        private string? nome;
        private double media;

        public string? Nome
        {
            get
            {
                return nome?.ToUpper();
            }
            set
            {
                nome = value;
            }
        }
        public double Media
        {
            set
            {
                if (value >= 0 && value <= 10)
                    media = value;
                else
                    Console.WriteLine("Nota não válida!");
            }
            get
            {
                return media;
            }
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine("Aluno: " + Nome + "\tnota: " + Media);
        }

        public bool EstaAprovado()
        {
            if (media >= 6)
            {
                return true;
            }
            else
                return false;
        }

        public void ExibirInformações()
        {
            Console.WriteLine("Status: " + (EstaAprovado() ? "Aprovado" : "Reprovado"));
        }

        /*Criar a classe Estudante (nome (get;set), media), implemente o encapsulamento dos atributos com validações e
        o método ExibirDetalhes(), a média só pode estar dentro do valor de 0 a 10, realize no mínimo 2 instâncias.
        Desenvolver os métodos: bool EstaAprovado(), true/false siga a regra >= 6 void ExibirInformações(), use o WriteLine 
        e acrescente o texto "Status", onde deverá ser chamado o método anterior. Dica use o operador ternário */
    }
}