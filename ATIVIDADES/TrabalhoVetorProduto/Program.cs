using TrabalhoVetorProduto;

//declarar o vetor de 6 elementos

//executar todos os passos do trabalho no Teams
internal class Program
{
    private static void Main(string[] args)
    {
        Produto[] vetProdutos = new Produto[6];
        for (int i = 0; i < vetProdutos.Length; i++)
        {
            vetProdutos[i] = new Produto();
            Console.WriteLine("Informe o cód. do produto: ");
            vetProdutos[i].codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o nome do produto: ");
            vetProdutos[i].nome = Console.ReadLine();
            Console.WriteLine("Informe o preço do produto: ");
            vetProdutos[i].preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o estoque do produto: ");
            vetProdutos[i].estoque = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < vetProdutos.Length; i++)
        {
            Console.Write($"Índice {i} - ");
            vetProdutos[i].CalcularSubTotal();
            vetProdutos[i].MostrarAtributos();
        }

        Console.WriteLine("*****************************************");
        Console.Write("Informe o aumento(%) a ser aplicado nos produtos de índices pares: ");
        double percent = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe a quantidade a ser retirado do estoque dos produtos de índices ímpares: ");
        int quantidade = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < vetProdutos.Length; i++)
        {
            if (i % 2 == 0)
                vetProdutos[i].CalcularAumento(percent);
            else
                vetProdutos[i].RetirarEstoque(quantidade);
        }

        Console.WriteLine("*****************************************");

        for (int i = 0; i < vetProdutos.Length; i++)
        {
            Console.Write($"Índice {i} - ");
            vetProdutos[i].CalcularSubTotal();
            vetProdutos[i].MostrarAtributos();
        }
    }
}