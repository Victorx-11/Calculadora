public class Program
{
    static void Main()
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Calculadora");

        bool opc = true;

        while (opc)
        {
            Console.WriteLine("-------------------------------");
            Console.Write("Digite o primeiro número: ");
            double PNum = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double SNum = double.Parse(Console.ReadLine());

            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("Qual operação deseja fazer: ");
            Console.WriteLine("(A) Soma");
            Console.WriteLine("(B) Subtração");
            Console.WriteLine("(C) Multiplicação");
            Console.WriteLine("(D) Divisão");
            Console.Write("Opção escolhida: ");
            char Escolha = Char.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");



            switch (Escolha)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("Resultado: {0} + {1} = {2}", PNum, SNum, Operacao.Soma(PNum, SNum));
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("Resultado: {0} - {1} = {2}", PNum, SNum, Operacao.Subtracao(PNum, SNum));
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("Resultado: {0} x {1} = {2}", PNum, SNum, Operacao.Multiplicacao(PNum, SNum));
                    break;
                case 'D':
                case 'd':

                    Console.WriteLine("Resultado: {0} / {1} = {2}", PNum, SNum, Operacao.Divisao(PNum, SNum));
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Deseja fazer outro cálculo? ");
            Console.WriteLine("(S) Sim");
            Console.WriteLine("(N) Não");
            Console.Write("Opção escolhida: ");
            char Opc = Char.Parse(Console.ReadLine());


            switch (Opc)
            {
                case 'S':
                case 's':
                    opc = true;
                    break;
                case 'N':
                case 'n':
                    opc = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
