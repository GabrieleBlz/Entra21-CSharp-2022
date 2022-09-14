using ListaExemplosArrays;

int escolha;

do
{
    Console.WriteLine(@"-------- MENU ---------
1º Exemplo ->
2º Exemplo ->
3º Exemplo ->
4º Exemplo ->
5º Exemplo ->
6º Exemplo ->
7º Exemplo ->
8º Exemplo ->
9º Exemplo ->
10º Exemplo ->
11º Exemplo ->");
    Console.WriteLine("Insira o número escolhido: ");
    escolha = int.Parse(Console.ReadLine());

    switch (escolha)
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

        case 6:
            Exemplo06 exemplo06 = new Exemplo06();
            exemplo06.Executar();
            break;

        case 7:
            Exemplo07 exemplo07 = new Exemplo07();
            exemplo07.Executar();
            break;

        case 8:
            Exemplo08 exemplo08 = new Exemplo08();
            exemplo08.Executar();
            break;

        case 9:
            Exemplo09 exemplo09 = new Exemplo09();
            exemplo09.Executar();
            break;

        case 10:
            Exemplo10 exemplo10 = new Exemplo10();
            exemplo10.Executar();
            break;

        case 11:
            Exemplo11 exemplo11 = new Exemplo11();
            exemplo11.Executar();
            break;
    }
} while (escolha != 0);