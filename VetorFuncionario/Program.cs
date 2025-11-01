using VetorFuncionario;

//declarar o vetor de funcionários com 3 elementos
//ao final some e mostre o total de salários pagos
internal class Program
{
    private static void Main(string[] args)
    {
        //declarar do vetor
        Funcionario[] vetFuncionario = new Funcionario[3];
        
        //o laço de repetição realizará o cadastro das contas
        double total = 0;
        for (int i = 0; i < vetFuncionario.Length; i++)
        {
            //instanciação de CADA índice
            vetFuncionario[i] = new Funcionario();
            Console.Write("Digite o código: ");
            vetFuncionario[i].codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o nome do funcionário: ");
            vetFuncionario[i].nome = Console.ReadLine();
            Console.Write("Digite o salário: ");
            vetFuncionario[i].salario = Convert.ToDouble(Console.ReadLine());
            total += vetFuncionario[i].salario;
        }
        Console.WriteLine($"O salário total é {total:c} dos funcionários");

        //apresentação das contas com foreach
        //o foreach APENAS pode ser usado para vetor que tenha conteúdo
        foreach (Funcionario c in vetFuncionario)
            c.MostrarAtributos();

        double soma = 0.0;
        foreach (Funcionario c in vetFuncionario)
        {
            soma += c.salario;
        }

        Console.WriteLine("A soma dos salários informados de todos os funcionários é R$" + soma);
        
    }
}