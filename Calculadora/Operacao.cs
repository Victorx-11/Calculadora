using System.Collections.Generic;

public class Operacao
{
    public static double Soma(double num1, double num2)
    {
        return num1 + num2;
    }

    public static double Subtracao(double num1, double num2)
    {
        return num1 - num2;
    }

    public static double Multiplicacao(double num1, double num2)
    {
        return num1 * num2;
    }

    public static double Divisao(double num1, double num2)
    {
        try
        {
            if (num2 == 0)
            {
                throw new ArgumentException("ERRO: O divisor não pode ser zero.");
            }

            return num1 / num2;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            return double.NaN;
        }
    }

}


