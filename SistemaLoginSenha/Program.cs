// Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.


//Criar o dicionario
//String list<string>

//Criar o menu
//Cadastrar usuário
//Realizar login


Dictionary<string, string> SistemaLogin = new Dictionary<string, string>();


MenuOpcoes();
void MenuOpcoes()
{
    Console.Clear();
    Console.WriteLine("Selecione uma das opções abaixo!");
    Console.WriteLine("1 Para cadastrar");
    Console.WriteLine("2 Para realizar login\n");
    string opcoes = Console.ReadLine()!;
    if (int.TryParse(opcoes, out int opcoesnumero))
    {
        switch (opcoesnumero)
        {
            case 1:
                cadastrar();
                break;
            case 2:
                login();
                break;
            default:
                Console.WriteLine("\nOpção incorreta, digite uma das opções sugeridas");
                Thread.Sleep(3000);
                MenuOpcoes();
                break;
        }
    }
    else
    {
        Console.WriteLine("\nOpção incorreta, digite uma das opções sugeridas");
        Thread.Sleep(3000);
        MenuOpcoes();

    }
}
void cadastrar()
{
    Console.Clear();
    Console.WriteLine("Digite o nome do usuário e pressione enter");
    string usuario = Console.ReadLine()!.ToLower();
    Console.Clear();
    Console.WriteLine($"Digite a senha do usuário {usuario}");
    string senha = Console.ReadLine()!;
    SistemaLogin.Add(usuario, senha);
    Console.WriteLine($"\nO usuário {usuario} foi cadastrado com sucesso!");

    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu inicial.");
    Console.ReadKey();
    MenuOpcoes();
}
void login()
{
    Console.Clear();
    Console.WriteLine("Para realizar o login, digite o nome do usuário e pressione enter");
    string loginUsuario = Console.ReadLine()!;
    if (SistemaLogin.ContainsKey(loginUsuario.ToLower()))
    {
        Console.WriteLine("\nDigite a senha do usuário e pressione enter");
        string senhaUsuario = Console.ReadLine()!;
        if (senhaUsuario == SistemaLogin[loginUsuario])
        {
            Console.WriteLine("\nLogin realizado com sucesso!!!");
            Thread.Sleep(3000);
            MenuOpcoes();
        }
        else
        {
            Console.WriteLine("\nSenha do usuário esta incorreto");
            Thread.Sleep(3000);
            Console.Clear();
            login();
        }
    }
    else
    {
        Console.WriteLine("\nUsuário não consta no sistema");
        Thread.Sleep(3000);
        Console.Clear();
        MenuOpcoes();
    }
}