using System;

namespace CaCalcClasse
{
    public class Funcoes
    {
        public bool QuerRepetir()//repetir a conta ou voltar pro menu
        {
            Console.WriteLine("Quer fazer a conta denovo? ");
            Console.WriteLine("[1]- Sim");
            Console.WriteLine("[2]- Não\n");
            Console.Write("Opção: ");
            int resposta;
            while (!int.TryParse(Console.ReadLine(), out resposta) || resposta < 1 || resposta > 2)
            {
                Funcoes.ApagarAviso();
                Console.Write("Digite um número válido! ");

            }
            return resposta == 1;
        }

        public double LerNumero(String mensagem)//verifica se o valor que o usuario digitou está correto
        {
            double valor;

            Console.Write(mensagem);

            while (!double.TryParse(Console.ReadLine(), out valor) || valor < 0)
            {
                Funcoes.ApagarAviso();
                Console.Write("Digite um número válido! ");

            }
            return valor;
        }

        public double mensagemdivisao()//Dá erro na divisão se o numero for menor que 0
        {
            double valor;

            while (!double.TryParse(Console.ReadLine(), out valor) || valor < 1)
            {
                Funcoes.ApagarAviso();
                Console.Write("Digite um número válido! ");

            }
            return valor;
        }
        public static void ApagarAviso()//sistema apagar linha, apaga pra linha unica
        {
            int linha = Console.CursorTop;
            Console.SetCursorPosition(0, linha - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, linha - 1);

        }
    }
}
