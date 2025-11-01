using HerancaCliente;
Cliente c = new Cliente();
        c.Codigo = 1;
        c.Nome = "Bia";
        c.Mostrar();
        
        ClienteFisico cf = new ClienteFisico();
        cf.Codigo = 2;
        cf.Nome = "Bel";
        cf.Rg = 123;
        cf.Mostrar();