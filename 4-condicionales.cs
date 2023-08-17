using System;

class Program
{
    public static void Main(string[] args)
    {
        int num1 = 2;
        int num2 = 3;

        //Comparar si son iguales
        Console.WriteLine(num1 == num2);

        //Comparar si son diferentes
        Console.WriteLine(num1 != num2);

        //Comparar si num1 es menor que num2
        Console.WriteLine(num1 < num2);

        //Comparar si num1 es mayor que num2
        Console.WriteLine(num1 > num2);

        //Comparar si num1 es menor o igual que num2
        Console.WriteLine(num1 <= num2);

        //Comparar si num1 es mayor o igual que num2
        Console.WriteLine(num1 >= num2);

        //Si num1 es igual a num2 -> imprime num1 es igual a num2
        if (num1 == num2)
        {
            Console.WriteLine("num1 es igual a num2");
        }
        //Si num1 es mayor a num2 -> imprime num1 es mayor a num2
        else if (num1 > num2)
        {
            Console.WriteLine("num1 es mayor a num2");
        }
        //Si no se cumple ninguna condicion -> imprime num1 es menor a num2
        else
        {
            Console.WriteLine("num1 es menor a num2");
        }
    }
}