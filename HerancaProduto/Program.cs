using HerancaProduto;
internal class Program
{
    private static void Main(string[] args)
    {
        Produto p = new Produto();
        p.Codigo = 1;
        p.Nome = "Caderno";
        p.Preco = 19.90M;
        p.Mostrar();

        Produto p2 = new Produto();
        p2.Codigo = 2;
        p2.Nome = "Borracha";
        p2.Preco = 2.50M;
        p2.Mostrar();

        Perecivel pr = new Perecivel();
        pr.Codigo = 3;
        pr.Nome = "Creme de Leite";
        pr.Preco = 6.5M;
        pr.DataFabricacao = "14/06/2024";
        pr.DataValidade = "12/05/2025";
        pr.Lote = 12345;
        pr.Mostrar();
    }
}