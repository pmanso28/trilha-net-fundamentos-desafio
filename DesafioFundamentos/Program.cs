using DesafioFundamentos.Models;

// Coloca o encoding para UTF-8 para exibir acentuação
// Changed the encode to UTF-8 in order to properly accomodate accentuation(Necessary in portuguese)
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" + //Welcome to the parking lot system! Please type the entry fee:
                  "Por favor digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora, por favor, digite o preço por hora:"); //Now please type the hourly fee:
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
// Instances the class, already with the formerly obtained values.
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:"); //Choose an option.
    Console.WriteLine("1 - Cadastrar veículo"); //Register vehicle(adds to the list of parked vehicles).
    Console.WriteLine("2 - Remover veículo"); //Remove Vehicle(removes the vehicle from the parked list).
    Console.WriteLine("3 - Listar veículos"); //Prints a list of the currently parked vehicles.
    Console.WriteLine("4 - Encerrar"); //Closes the program.

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida"); //Invalid Option.
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar"); //Press any Key to continue.
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou"); //The Program has finished.
