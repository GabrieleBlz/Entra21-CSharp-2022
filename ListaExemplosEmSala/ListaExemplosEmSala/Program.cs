using ListaExemplosEmSala;

int opcao;

do
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(@"----------- MENU ------------- 
1º Exemplo ->
2º Exemplo ->
3º Exemplo -> ");
    Console.WriteLine("Escolha um exemplo: ");
    opcao = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (opcao)
    {
        case 1:
            Exemplo01 exemplo01 = new Exemplo01();
            exemplo01.Executar();
            break;

        case 2:
            Exemplo02 exemplo02 = new Exemplo02();
            exemplo02.Executar();
            break;

        case 3:
            Exemplo03 exemplo03 = new Exemplo03();
            exemplo03.Executar();
            break;

        case 4:
            Exemplo04 exemplo04 = new Exemplo04();
            exemplo04.Executar();
            break;

        case 5:
            Exemplo05 exemplo05 = new Exemplo05();
            exemplo05.Executar();
            break;
    }
} while (opcao != 0);