using System;
public class Ejercicio3

{
    public static void Calculadora()
    {
        bool continuar = true;
        while(continuar)
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8; 
        Console.Write("Ingrese su primer valor: ");
        decimal primerValor;
        while (!decimal.TryParse(Console.ReadLine(), out primerValor))
        {
            Console.Write("Valor no válido. Ingrese el primer valor: ");
        }

        Console.Write("Ingrese su segundo valor: ");
        decimal segundoValor;
        while (!decimal.TryParse(Console.ReadLine(), out segundoValor))
        {
            Console.Write("Valor no válido. Ingrese el segundo valor: ");
        }

        Console.Write("Ingrese 1 para sumar, 2 para restar, 3 para multiplicar, 4 para dividir: ");
        int operador;
        while (!int.TryParse(Console.ReadLine(), out operador) || operador < 1 || operador > 4)
        {
            Console.Write("Operación no válida. Ingrese un número del 1 al 4: ");
        }
        decimal resultado = 0;

    switch (operador)
    {
        case 1:
            resultado = primerValor + segundoValor;
            break;
        case 2:
            resultado = primerValor - segundoValor;
            break;
        case 3:
            resultado = primerValor * segundoValor;
            break;
        case 4:
            if (segundoValor != 0)  
            {
                resultado = primerValor / segundoValor;
            } 
            else{
                Console.WriteLine("No se puede dividir entre 0");
                return;
            }
        break;
    }
    
    Console.WriteLine($"El resultado es {resultado}");
    ConsoleKey tecla;
            do
            {
            Console.Write("Presiona enter para salir o espacio para continuar...");
            ConsoleKeyInfo info = Console.ReadKey(); 
            tecla = info.Key;

                if (tecla == ConsoleKey.Enter)
                {
                    continuar = false;
                    Console.Clear();
                }
                else if (tecla == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                }
                else{
                        Console.WriteLine("Ingrese una tecla válida");
                    }
            }
        while (tecla != ConsoleKey.Enter && tecla != ConsoleKey.Spacebar);

    }
}
}