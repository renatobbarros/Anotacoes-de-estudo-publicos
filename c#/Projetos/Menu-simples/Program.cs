Console.WriteLine("Olá, seja bem vindo(a), qual é o seu nome?");
string nomeUsuario = Console.ReadLine();
Console.WriteLine($"\n{nomeUsuario}, O que você vai querer hoje \n(digite apenas o numero)\n");
string opcao;

while (true)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Mudar meu Nome");
    Console.WriteLine("2 - Ler uma piada");
    Console.WriteLine("3 - Sair");

    opcao = Console.ReadLine(); 

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Qual seu novo nome? ");
            string nomeUsuarioNovo = Console.ReadLine();
            Console.WriteLine($"Olá, {nomeUsuario}");
            break;

        case "2":
            Console.WriteLine("\nUma piada\n");
            Console.WriteLine("Adeus amigo, ate a proxima");
            return;

        case "3":
            Console.WriteLine("Adeus amigo, ate a proxima");
            return;

        default:
            Console.WriteLine("\nOpção inválida. Tente novamente.\n");
            break;
    }
}