using System;
using System.Globalization;
public class Ejercicio2

{
    public static void Conversion()
    {
        Console.Write("Ingrese su valor: ");
        double valorCOP;
        while (!double.TryParse(Console.ReadLine(), out valorCOP))
        {
            Console.Write("Valor no válido. Ingrese un valor en pesos: ");
        }
        Console.OutputEncoding = System.Text.Encoding.UTF8; 

        double tasaUSD = 0.00026; 
        double tasaEUR = 0.00024;
        double tasaJP = 0.035;

        double valorUSD = valorCOP * tasaUSD;
        double valorEUR = valorCOP * tasaEUR;
        double valorJPY = valorCOP * tasaJP;

        Console.WriteLine($"Valor en COP: {valorCOP.ToString("C", new CultureInfo("es-CO"))}");
        Console.WriteLine($"Valor en USD: {valorUSD.ToString("C", new CultureInfo("en-US"))}");
        Console.WriteLine($"Valor en EUR: {valorEUR.ToString("C", new CultureInfo("fr-FR"))}");
        Console.WriteLine($"Valor en JPY: {valorJPY.ToString("C", new CultureInfo("ja-JP"))}");

        Console.Write("Presiona cualquier tecla para continuar...");
        Console.ReadKey(); 
        Console.Clear();
    }
}