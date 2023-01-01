using FaveroBank.Models;

// Adicionando Encoding para permitr acentuação no código;
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Declarando as variáveis utilizadas no código;
decimal depositoConta = 0;
decimal saqueConta = 0;
decimal calculaValor = 0;
decimal novoValorDepositado = 0;

// Adicionando o número para finalizar o programa;
string opcoesMenu = string.Empty;

// Opções do menu do switch case;
bool menuBanco = true;

// Sentenciando a classe ContaCorrente;
ContaCorrente cc = new ContaCorrente(depositoConta, saqueConta, calculaValor, novoValorDepositado);

// Menu do programa
while (menuBanco)
{
    Console.Clear();
    Console.WriteLine("::Bem vindo ao Favero Bank, o seu banco eletrônico::");
    Console.WriteLine("Digite a opção desejada: ");
    Console.WriteLine("1 - Depositar valores");
    Console.WriteLine("2 - Sacar valores");
    Console.WriteLine("3 - Extrato bancário");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            cc.DepositarValor();
            break;

        case "2":
            cc.SacarValor();
            break;

        case "3":
            cc.ExtratoValor();
            break;

        case "4":
            menuBanco = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");






