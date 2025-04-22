using System;
public class Ejercicio5
{
    public static void Operadorternario()
    {
        int edad = 50;
        string mensaje = (edad >= 18) ? 
        ((edad<40) ? "Es joven" : "Es viejo") 
        : "Menor de edad";
        Console.WriteLine(mensaje);
    }
}