using ListFuncionario;
internal class Program
{
    private static void Main(string[] args)
    {
        //declarar do vetor
        //Funcionario[] vetFuncionario = new Funcionario[3];
        List<Funcionario> vetFuncionario = new List<Funcionario>();
        
        //o laço de repetição realizará o cadastro das contas
        double total = 0;

        for (int i = 0; i < 3; i++)
        {
            Funcionario f = new Funcionario();
            Console.Write("Digite o código: ");
            f.codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o nome do funcionário: ");
            f.nome = Console.ReadLine();
            Console.Write("Digite o salário: ");
            f.salario = Convert.ToDouble(Console.ReadLine());
            total += f.salario;
            vetFuncionario.Add(f);
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