using AbstrataCliente;
// intancia correta, mas quando usamos a palavra abstract NÃO EXECUTA
// Cliente c = new Cliente();
Cliente cf = new ClienteFisico(1,"Ana",19, 100);
cf.Mostrar();
Cliente cj = new ClienteJuridico(2,"Empresa",49, 222);
cj.Mostrar();
Teste t = new Teste();
t.AvaliarIdadeCliente(cf);
t.AvaliarIdadeCliente(cj);