using ConstrutorFuncionario;

Funcionario f1 = new Funcionario();
f1.MostrarAtributos();

Funcionario f2 = new Funcionario(1);
f2.MostrarAtributos();

Funcionario f3 = new Funcionario(2, "Mateus");
f3.MostrarAtributos();

Funcionario f4 = new Funcionario(3, "Paulo", 1000);
f4.MostrarAtributos();

Console.WriteLine("Qtde de instâncias: "+ Funcionario.Contador);
