using EncapsulamentoEstudante;

Estudante e = new Estudante();
Console.WriteLine("Informe o nome do aluno: ");
e.Nome = Console.ReadLine();
Console.WriteLine("Informe a nota do aluno: ");
e.Media = Convert.ToInt32(Console.ReadLine());

Estudante e1 = new Estudante();
Console.WriteLine("Informe o nome do aluno: ");
e1.Nome = Console.ReadLine();
Console.WriteLine("Informe a nota do aluno: ");
e1.Media = Convert.ToInt32(Console.ReadLine());

e.ExibirDetalhes();
e.ExibirInformações();
e1.ExibirDetalhes();
e1.ExibirInformações();




