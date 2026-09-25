using System;
// Espacio de nombres
namespace CS2
{
    //Clase principal
    class Program
    {
        // Funcion principal
        static void Main(string[] args)
        {
            // Sesion 5: Tipos de datos
            // Sintaxis para declarar variables
            // tipo_de_dato identificador_variable;
            // 1. Entero
            int a;
            // 2. Cadena de texto
            string s;
            // 3.1 Flotante (precision sencilla)
            float f;
            // 3.2 Flotante (precision doble)
            double d;
            // 4. Boleano (logico)
            bool b;
            // Inicializaciones
            a = 5;
            s = "Exactas";
            f = 8.5F;
            d = 9.5D;
            b = true;
            // Palabra reservada: Identificador especial predefinido para el compilador.
            // Interpolacion: Combinacion de datos dentro de una cadena.
            // Impresiones
            Console.WriteLine($"Entero: {a}");
            Console.WriteLine($"Cadena de texto: {s}");
            Console.WriteLine($"Flotante (precision sencilla): {f}");
            Console.WriteLine($"Flotante (precision doble): {d}");
            Console.WriteLine($"Booleano: {b}");
        } // Termino de la funcion principal
    } // Termino de la clase principal
} // Termino del espacio de nombres