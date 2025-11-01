using EncapsulamentoFuncionario;
internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario f = new Funcionario();
        f.Codigo = 1; //set
        Console.WriteLine("Número: " + f.Numero);//get
    }
}