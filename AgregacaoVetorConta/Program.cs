using AgregacaoVetorConta;

Conta c1 = new Conta();
c1.Numero = 1;
c1.Saldo = 10000;
c1.VetTitulares = new List<Cliente>();
for (int i = 0; i < 3; i++)
{
    Cliente objetoCliente = new Cliente();
    Console.WriteLine("Digite o nome: ");
    objetoCliente.Nome = Console.ReadLine();
    Console.WriteLine("Digite o RG: ");
    objetoCliente.Rg = Convert.ToInt32(Console.ReadLine());
    c1.VetTitulares.Add(objetoCliente);
}

Console.WriteLine("\n\nApresentação dos sócios\n");
// var implicitamente representa o tipo/classe Cliente
foreach (var cliente in c1.VetTitulares) 
    cliente.Mostrar();
