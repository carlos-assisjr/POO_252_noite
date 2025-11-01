using EncapsulamentoProduto;
internal class Program
{
    private static void Main(string[] args)
    {
        Produto p = new Produto();
        p.Codigo = 1; //set
        p.Nome = "mouse"; //set
        p.Preco = 50; //set

        if (p.Preco > 10)
            Console.WriteLine("Preço alto " + p.Preco);//get
    }
}