using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 6 - Atribuições de variáveis");

        int idade = 30;
        int idadeAna = idade;

       

        //a idade ainda é 30, seria 25 se eu definisse a variavel 25 em baixo de aonde definiu 30
        idade = 25;
        Console.WriteLine(idadeAna);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}