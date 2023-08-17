using System;

class Program
{
    public static void Main(string[] args)
    {
        int num1 = 30;
        int num2 = 20;

        //Operador de suma
        int num3 = num1 + num2;
        Console.WriteLine(num3);

        string hola = "Hola";
        string mundo = "mundo";
        Console.WriteLine(hola + " " + mundo);

        //Operador de resta
        Console.WriteLine(num1 - num2);

        //Operador de multiplicacion
        Console.WriteLine(num1 * num2);

        //Operador de division  
        Console.WriteLine(num1 / num2);

        //Operador de modulo
        Console.WriteLine(num1 % num2);
    }
}