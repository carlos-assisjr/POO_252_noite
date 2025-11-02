using TrabalhoComposicaoBanco;

class Program
{
    static void Main(string[] args)
    {

        Banco meuBanco = new Banco();

        ContaCorrente cc1 = meuBanco.AbrirConta(saldoInicial: 1000.00, limiteCheque: 500.00);

        Poupanca p1 = meuBanco.AbrirPoupanca(saldoInicial: 500.00);

        ContaCorrente cc2 = meuBanco.AbrirConta(saldoInicial: 50.00, limiteCheque: 1000.00);

        Console.WriteLine("\n--- Testes da Conta Corrente 1 ---");
        cc1.Depositar(1000.00); 
        cc1.Sacar(1500.00);    
        cc1.GerarExtrato();
        cc1.Sacar(500.00);     
        cc1.Sacar(500.00);    

        Console.WriteLine("\n--- Testes da Poupança 1 ---");
        p1.Depositar(100.00);  
        p1.Sacar(50.00);       
        p1.GerarRendimento(0.005); 
        p1.Sacar(500.00); 

        meuBanco.DecretarFalencia();

    }
}

