using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 11 - Calcula Poupança");

        // trecho de código omitido

        double investimento = 1000;

        for (int mes = 1; mes <= 12; mes = mes++)
        {
            //investimento = investimento + investimento * 0.005;
            //investimento = investimento * 1.005;
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}