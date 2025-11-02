using TrabalhoConstrutorAluno;

Aluno a = new Aluno();
Console.Write("Informe o nome do 1º aluno: ");
a.Nome = Console.ReadLine();

Aluno a1 = new Aluno();
Console.Write("Informe o nome do 2º aluno: ");
a1.Nome = Console.ReadLine();

Console.Write("Informe o nome do 3º aluno: ");
Aluno a2 = new Aluno(Console.ReadLine());

Console.Write("Informe o nome do 4º aluno: ");
Aluno a3 = new Aluno(Console.ReadLine());

a.MostrarAtributos();
a1.MostrarAtributos();
a2.MostrarAtributos();
a3.MostrarAtributos();

/* 15704824130001 - primeiro aluno
Criar a classe Aluno (Ra, Nome, Contador/static)
Crie dois construtores, um vazio/padrão e outro com
o parâmetro nome

o tipo do contador tem que ser long

Use o construtor static para inicializar a variável
contador 
Nos outros construtores incremente o contador e o
armazene no atributo Ra
Implemente o método MostrarAtributos()

Faça instâncias e apresente os atributos */
