using ListaExercicios;

int opcao;
do
{
    Console.WriteLine(@"-------------------MENU-------------------
        1 - EXERCICIO 01
        2 - EXERCICIO 02
        3 - EXERCICIO 03
        4 - EXERCICIO 04
        5 - EXERCICIO 05
        6 - EXERCICIO 06
        7 - EXERCICIO 07
        8 - EXERCICIO 08");

    Console.Write("Digite a opção escolhida: ");
    opcao = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    switch (opcao)
    {
        case 1:
            Exercicio01 exercicio01 = new Exercicio01();
            exercicio01.Executar();
            break;

        case 2:
            Exercicio02 exercicio02 = new Exercicio02();
            exercicio02.Executar();
            break;

        case 3:
            Exercicio03 exercicio03 = new Exercicio03();
            exercicio03.Executar();
            break;

        case 4:
            Exercicio04 exercicio04 = new Exercicio04();
            exercicio04.Executar();
            break;

        case 5:
            Exercicio05 exercicio05 = new Exercicio05();
            exercicio05.Executar();
            break;

        case 6:
            Exercicio06 exercicio06 = new Exercicio06();
            exercicio06.Executar();
            break;

        case 7:
            Exercicio07 exercicio07 = new Exercicio07();
            exercicio07.Executar();
            break;

        case 8:
            Exercicio08 exercicio08 = new Exercicio08();
            exercicio08.Executar();
            break;
    }
} while (opcao != 0);