using AbstrataCliente;
// intancia correta, mas quando usamos a palavra abstract NÃO EXECUTA
// Cliente c = new Cliente();
Cliente cf = new ClienteFisico(1, "Ana",19, 100);
cf.Mostrar();
