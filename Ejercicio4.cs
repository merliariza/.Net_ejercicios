using System;
public class Ejercicio4
{
    public static void Operaciones()
    {
        
        // 📌  Operaciones básicas y jerarquía de operadores matemáticos
        int a = 10, b = 5, c = 2;
        int resultado1 = a + b * c - 8 / 4; // Multiplicación y división primero
        Console.WriteLine($"Resultado1 (10 + 5 * 2 - 8 / 4): {resultado1}"); //18
        int resultado2 = (a + b) * c - 8 / 4; // Paréntesis alteran el orden
        Console.WriteLine($"Resultado2 ((10 + 5) * 2 - 8 / 4): {resultado2}"); //26
        // 📌  Operaciones de incremento y decremento
        int x = 5;
        int y = ++x + x--; // ++x incrementa primero, x-- se evalúa antes derestar
        Console.WriteLine($"y = ++x + x--: {y} (x final: {x})"); // 11 (x = 5)
        // 📌  Operaciones lógicas y relacionales combinadas
        int edad = 20;
        bool tieneLicencia = true;
        bool puedeConducir = (edad >= 18) && tieneLicencia;
        Console.WriteLine($"¿Puede conducir? {puedeConducir}"); // true
        // 📌  Uso de operadores lógicos con relacionales
        int temperatura = 30;
        bool haceFrio = !(temperatura > 15); // Negación lógica
        Console.WriteLine($"¿Hace frío? {haceFrio}"); // false
        // 📌  Uso de operadores de asignación combinados
        int numero = 10;
        numero += 5; // Equivalente a numero = numero + 5
        numero *= 2; // Equivalente a numero = numero * 2
        Console.WriteLine($"Número tras operaciones: {numero}"); // 30
        // 📌  Expresión Compleja combinando todo
        int resultadoFinal = ((a * b) / c + x) - (numero % 4) * (y - 2);
        Console.WriteLine($"Resultado final: {resultadoFinal}");
    }
}