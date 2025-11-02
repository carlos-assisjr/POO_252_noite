using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoConstrutorAluno
{
    public class Aluno
    {
        public static long Contador { get; set; }

        public long Ra { get; set; }
        public string? Nome { get; set; }

        static Aluno() //construtor padrão
        {
            Contador = 15704824130000;
        }

        public Aluno() //construtor padrão
        {
            Contador++;
            Ra = Contador;
        }

        public Aluno(string? nome)
        {
            Contador++;
            Ra = Contador;
            Nome = nome;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Nome: {Nome} | RA nº: {Ra}");
        }

    }
}