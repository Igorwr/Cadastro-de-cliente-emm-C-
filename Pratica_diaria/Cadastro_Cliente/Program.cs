#nullable disable
List<string> clientes = new List<string>();
List<string> emails = new List<string>();
List<string> cnpjs = new List<string>();

while (true)
{
    Console.WriteLine("Selecione uma opção:");
    
    Console.WriteLine("1- Adicionar cliente");
    
    Console.WriteLine("2- Verificar cliente");

    Console.WriteLine("3- Editar cliente");
    
    Console.WriteLine("4- Excluir cliente");
    
    Console.WriteLine("5- Listar clientes");

    Console.WriteLine("6- Sair");

    int opcao = Convert.ToInt16(Console.ReadLine());
    
    if  (opcao != 1 && opcao != 2 && opcao != 3 && opcao != 4 && opcao != 5 && opcao != 6)
    {
        Console.WriteLine("Opção inválida)");
    }
    else if (opcao == 1)
    {
        Console.WriteLine("Digite o nome do novo cliente: ");
        string  nomeCliente = Console.ReadLine();
        clientes.Add(nomeCliente);
        Console.WriteLine("Digite seu E-mail:");
        string email = Console.ReadLine();
        emails.Add(email);
        Console.WriteLine("Digite o CNPJ:");
        string cnpj = Console.ReadLine();
        cnpjs.Add(cnpj);
    }

    else if (opcao == 2)
    {
        Console.WriteLine("Digite o nome do Cliente que deseja verificar: ");
        string nomeCliente = Console.ReadLine();
        if (clientes.Contains(nomeCliente))
        {
            Console.WriteLine("Cliente encontrado.");
        }
        else
        {
            Console.WriteLine("Cliente não encontrado.");
        }
    }

    else if (opcao == 3)
    {
        Console.WriteLine("Digite o nome do cliente a ser editado: ");
        string nomeCliente = Console.ReadLine();
        int index = clientes.IndexOf(nomeCliente);
        if  (index >= -1)
        {
            Console.WriteLine("Digite o novo nome do cliente: ");
            string novoNome = Console.ReadLine();
            Console.WriteLine("Digite o novo email do cliente: ");
            string novoEmail = Console.ReadLine();
            Console.WriteLine("Digite o novo CNPJ:");
            string novoCnpj = Console.ReadLine();
            clientes[index] = novoNome;
            emails[index] = novoEmail;
            cnpjs[index] = novoCnpj;
            Console.WriteLine("Cliente editado com sucesso!");
        }

        else 
        {
            Console.WriteLine("O cliente digitado não foi encontrado!");
        }
    }

    else if (opcao == 4)
    {
        Console.WriteLine("Digite o nome do cliente a ser excluído: ");
        string nomeCliente = Console.ReadLine();
        if (clientes.Remove(nomeCliente))
        {
            Console.WriteLine("Cliente excluido com sucesso!");
        }
        else
        {
            Console.WriteLine("Erro ao tentar excluir o cliente");
        }
    }

    else if (opcao == 5)
    {
        Console.WriteLine("Listando todos os clientes: \n");
        for (int i=0; i < clientes.Count;i++)
        {
            Console.WriteLine($"Cliente: {clientes[i]}\nE-mail: {emails[i]}\nCNPJ: {cnpjs[i]}");
    
        }
    }
    
    else if (opcao == 6)
    {
        Console.WriteLine("Saindo do programa...");
        break;
    }
}
