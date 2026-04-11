using CaCalcClasse;
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Blue;
Contas c = new Contas()!;//declarando objeto para as contas
Funcoes f = new Funcoes()!;//declarando objeto para as funções
int opcao;

while (true)//voltar pro menu
{
    Console.Clear();
    Console.SetCursorPosition(50, 0); Console.WriteLine("Calculadora De DS");
    Console.WriteLine("[1] Adição");
    Console.WriteLine("[2] Subtração");
    Console.WriteLine("[3] Divisão");
    Console.WriteLine("[4] Multiplicação");
    Console.WriteLine("[5] Sair\n");
    Console.Write("Opção: ");
    while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 5)
    {
        Funcoes.ApagarAviso();
        Console.Write("Digite uma opção válida! ");
    }

    do
    {
        if (opcao > 0 && opcao < 5)
        {
            Console.Clear();
            c.Num1 = f.LerNumero("Primeiro número: ");//chamando metodo LerNumero
            c.Num2 = f.LerNumero("Segundo número: ");
        }
        switch (opcao)
        {
            case 1://somar        
                Console.WriteLine(c.Somar());
                break;

            case 2://subtrair
                Console.WriteLine(c.Subtrair());
                break;

            case 3://dividir
                Console.WriteLine(c.Dividir());
                break;

            case 4://multiplicar
                Console.WriteLine(c.Multiplicar());
                break;

            case 5:
                Console.Clear();
                Console.WriteLine("Saindo...");
                Thread.Sleep(1000);
                return;
        }
    } while (f.QuerRepetir());//Quando termina, pergunta se quer repetir a conta ou voltar pro menu
}

