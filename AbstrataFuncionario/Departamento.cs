using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }

        public List<Funcionario> VetF { get; set; }
        public Departamento(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
        public void Mostrar()
        {
            Console.WriteLine($"Código do departamento: {Codigo} Nome: {Nome}");
        }
        public void AdmitirFuncionario(Funcionario f)
        {
            VetF.Add(f);
        }
        public void ListarFuncionario()
        {
            foreach (var f in VetF)
                f.Mostrar();
        }
        public void DemitirFuncionario(int codigo)
        {
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt(i);
                if (codigo == f.Codigo)
                    VetF.Remove(f);
            }
        }
        public double CalcularFolha(int diasUteis)// dias uteis parametro
        {
            double folha = 0;
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt(i);
                folha += f.CalcularSalario(diasUteis);//dias uteis argumento
            }
            return folha;
        }
    }
}