using ClasseProduto;
internal class Program
{
    private static void Main(string[] args)
    {
        //faça as instâncias;
        Produto p1 = new Produto();
        Console.Write("Informe o código do produto: ");
        p1.codigo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o nome do produto: ");
        p1.nome = Console.ReadLine();
        Console.Write("Digite o preço do produto: ");
        p1.preco = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe o estoque do produto: ");
        p1.estoque = Convert.ToInt32(Console.ReadLine());

        p1.MostrarAtributos();
        Console.Write("Informe o percentual de aumento do produto: ");
        double percent = Convert.ToDouble(Console.ReadLine());
        //envio de mensagem - percent é o argumento 
        p1.CalcularAumento(percent);//chamada da função
        p1.MostrarAtributos();
        p1.RetirarEstoque(5);
        p1.MostrarAtributos();
        p1.CalcularSubTotal();
        p1.MostrarAtributos();
    }
}