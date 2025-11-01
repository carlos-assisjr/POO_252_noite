using HerancaFuncionario;

Funcionario f = new Funcionario(1000);
Console.WriteLine($"Funcionário {f.CalcularBonificacao():c}");

Secretario s = new Secretario(1000);
Console.WriteLine($"Secretario {s.CalcularBonificacao():c}");

Gerente g = new Gerente(1000);
Console.WriteLine($"Gerente {g.CalcularBonificacao():c}");

Diretor d = new Diretor(1000);
Console.WriteLine($"Diretor {d.CalcularBonificacao():c}");
