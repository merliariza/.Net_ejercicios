using System;
using System.Globalization; 
public class Ejercicio1

{
    public static void Valores()
    {
        Console.Write("Ingrese su valor: ");
        double valorCOP;
        while (!double.TryParse(Console.ReadLine(), out valorCOP))
        {
            Console.Write("Valor no válido. Ingrese un valor en pesos: ");
        }
        Console.OutputEncoding = System.Text.Encoding.UTF8; 


        Console.WriteLine($"{valorCOP.ToString("C3", new CultureInfo("en-US"))}");
        Console.WriteLine($"{valorCOP.ToString("C", new CultureInfo("fr-FR"))}");
        Console.WriteLine($"{valorCOP.ToString("C", new CultureInfo("ja-JP"))}");
        Console.WriteLine($"{valorCOP.ToString("C", new CultureInfo("en-JP"))}");

        Console.Write("Presiona cualquier tecla para continuar...");
        Console.ReadKey(); 
        Console.Clear();
    }
}