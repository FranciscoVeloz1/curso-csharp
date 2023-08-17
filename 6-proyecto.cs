using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al programa de cálculo de giro de llanta.");

        // Solicitar al usuario el diámetro de la llanta en centímetros
        Console.Write("Ingrese el diámetro de la llanta en centímetros: ");
        double diametroLlanta = double.Parse(Console.ReadLine());

        // Solicitar al usuario la distancia en centímetros que desea avanzar
        Console.Write("Ingrese la distancia que desea avanzar en centímetros: ");
        double distanciaAvance = double.Parse(Console.ReadLine());

        // Calcular la circunferencia de la llanta (distancia que recorre en un giro completo)
        double circunferenciaLlanta = Math.PI * diametroLlanta;

        // Calcular los grados de giro necesarios para avanzar la distancia indicada
        double gradosGiro = (360.0 * distanciaAvance) / circunferenciaLlanta;

        Console.WriteLine($"Para avanzar {distanciaAvance} centímetros, la llanta debe girar {gradosGiro.ToString("0.00")} grados.");

    }
}