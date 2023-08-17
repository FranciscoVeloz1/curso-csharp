using System;

class Program
{
    public static void Main(string[] args)
    {
        //Mandamos a llamar todas las funciones de Program y las guaradmos en p
        var p = new Program();

        p.imprimir("Hola calculadora");

        int suma = p.suma(2, 1);
        p.imprimir($"suma {suma.ToString()}");

        int resta = p.resta(2, 1);
        p.imprimir($"resta {resta.ToString()}");

        int multiplicacion = p.multiplicacion(2, 1);
        p.imprimir($"multiplicacion {multiplicacion.ToString()}");

        int division = p.division(2, 0);
        p.imprimir($"division {division.ToString()}");
    }

    //Funcion para imprimir en consola
    void imprimir(string texto)
    {
        Console.WriteLine(texto);
    }

    //Funcion para realizar sumas entre 2 numeros
    int suma(int num1, int num2)
    {
        return num1 + num2;
    }

    //Funcion para realizar restas entre 2 numeros
    int resta(int num1, int num2)
    {
        return num1 - num2;
    }

    //Funcion para realizar multiplicaciones entre 2 numeros
    int multiplicacion(int num1, int num2)
    {
        return num1 * num2;
    }

    //Funcion para realizar divisiones entre 2 numeros
    int division(int num1, int num2)
    {
        // Asegurarse de no dividir por cero
        if (num2 != 0)
        {
            return num1 / num2;
        }
        else
        {
            Console.WriteLine("Error: División por cero no permitida.");
            return 0; // o cualquier valor que quieras devolver en caso de división por cero
        }
    }

}