using System;

class Program
{
    public static void Main(string[] args)
    {
        //Variables numericas
        int entero = 10;
        double decimales = 10.22;
        float flotante = 10.23F;

        Console.WriteLine(entero);
        Console.WriteLine(decimales);
        Console.WriteLine(flotante);

        //Variables de texto
        string texto = "Hola mundo";
        Console.WriteLine(texto);

        //Variables booleanas (solo pueden ser true o false)
        bool estado = true;
        Console.WriteLine(estado);
        estado = false;
        Console.WriteLine(estado);

        //Variable sin iniciar
        string sinIniciar;
        sinIniciar = "Iniciando variable";
        Console.WriteLine(sinIniciar);
    }
}
