using System;

namespace CS3
{
    // Clase principal
    class Program
    {
        // Funcion principal
        static void Main (string[] args)
        {
            
            // Sesion 6: Operadores
            //Declaracion e Inicializaciones
            double a = 1;
            double b = 2;
            double resultado = 0;
            // 1. Operadores aritmeticos
            // a. Suma: +
            resultado = a+b;
            Console.WriteLine($"Suma: {resultado}");
            // b. Resta: -
            resultado = a-b;
            Console.WriteLine($"Resta: {resultado}");
            // c. Multiplicacion *
            resultado = a*b;
             Console.WriteLine($"Multiplicación: {resultado}");
            // d. Division: /
            resultado = a/b;
            Console.WriteLine($"División: {resultado}");
            // e. Resto (modulo): %
            resultado = a%b;
            Console.WriteLine($"Residuo: {resultado}");
            // Incrementos y decrementos
            //resultado = resultado + 9;
            resultado += 9;
            Console.WriteLine($"Resultado: {resultado}");
            /*
            // Incrementos y decrementos
            resultado = resultado + 9;
            Console.Writeline()
            2. Operadores comparativos
            a. Igualdad: ==
            b. Diferencias: !=
            c. Menor que: <
            d. Mayor que: >
            e. Menor o igual que: <=
            f. Mayor o igual que: >=
            */
            //Sesion 7: Operadores comparativos
            bool m = false;
            m = 4 == 10;
            Console.WriteLine($"Igualdad: {m}");
            m = 5 != 5;
            Console.WriteLine($"Diferencia: {m}");
            m = 10 > 6;
            Console.WriteLine($"Mayor que: {m}");
            m = 13 < 20;
            Console.WriteLine($"Menor que: {m}");
            // Menor o igual que
            // 1. Escribir una expresion que de como resultado true.
            m = 11 <= 15;
            Console.WriteLine($"Menor o igual que: {m}");
            // Mayor o igual que
            // 2. Escribir una expresion que de como resultado false.
            m = 9 >= 10;
            Console.WriteLine($"Mayor o igual que: {m}");
            // 3. Operadores logicos
            // a. Y (AND): &&
            // b. O (OR): ||
            bool e = false; // Entrada 1
            bool f = true; //Entrada 2
            bool d = false; // Resultado
            d = e && f;
            Console.WriteLine($"Y: {d}");
            d = e || f;
            Console.WriteLine($"O; {d}");
        } // Termino de funcion principal
    } // Termino de la clase principal
} // Termino del espacio de nombres