using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

        //caracteres = sinais e etc 
        char letra = 'a';
        Console.WriteLine(letra);

        //defino uma letra que vira caracter
        letra = (char)65;
        Console.WriteLine(letra);

        //tem q estar entre aspas para defiir uma soma de numeros q da um caracter
        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        //uso o " @ " para iformar que eu quero que quebre linha, tenho deixar bem junto no começo do codigo pq se n leh os espaços
        string cursos = @"Cursos disponíveis: 
- Go
- C#
- Python
- Java";
        Console.WriteLine(cursos);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}