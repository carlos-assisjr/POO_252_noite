using ConstrutorConta;

Conta c1 = new Conta();
c1.MostrarAtributos();

Conta c2 = new Conta(2, "Bia");
c2.MostrarAtributos();

Conta c3 = new Conta(3);
c3.MostrarAtributos();

Conta c4 = new Conta(4, "Mateus", 10000000);
c4.MostrarAtributos();
