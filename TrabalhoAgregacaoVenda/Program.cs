using TrabalhoAgregacaoVenda;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\t*** Início do Sistema ***");
        //instanciando o vendedor
        Vendedor vendedor1 = new Vendedor();
        Console.WriteLine("Insira qual a verba disponível pelo comprador: ");
        double verbaInicial = Convert.ToDouble(Console.ReadLine());  
        Comprador comprador1 = new Comprador(verbaInicial);
        Console.WriteLine("\n\t*** Verba Inicial ***");
        comprador1.MostrarAtributo();
        //Entrada do estoque
        Produto produtoA = new Produto("Xbox-VideoGame", 990.90);
        Produto produtoB = new Produto("Microondas", 500.00);
        Produto produtoC = new Produto("Forno", 1000.00);
        //Apresentação da lista dos produtos
        Console.WriteLine("\n\t*** Lista de produtos escolhidos ***");
        produtoA.MostrarAtributo();
        produtoB.MostrarAtributo();
        produtoC.MostrarAtributo();
        //Execução do método de venda
        Venda venda = new Venda(comprador1, vendedor1);
        Console.WriteLine("\n\t*** Processando Vendas ***");
        venda.Vender(produtoA); 
        venda.Vender(produtoB); 
        venda.Vender(produtoC); 
        
        venda.MostrarAtributo();
        Console.WriteLine("\n\t--- Venda finalizada ---");
    }
}