using System;
using System.Diagnostics.Tracing;

namespace SE1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //sesion 10: resolucion de examen
            //Ejercicio #1: Crear proyecto C#
            //Ejercicio #2: Sintaxis
            int a;
            double b;
            //Ejercicio #3: Interpolacion
            a = 10;
            b = 12.5;
            Console.WriteLine($"Este es el valor de a:{a}");
            Console.WriteLine($"Este es el valor de b:{b}");
            //Ejercitacion #4: Incrementos y decrementos
            int c = 0;
            int d = -1;
            c += 1;
            c -= 5;
            d += 1;
            d -= 4;
            //Ejercicio #5: Operador resto
            int residuo = 40 % 16;
            Console.WriteLine($"Residuo:{residuo}");
            //Ejercicio #6: Operadores aritmeticos
            double resultado = 0;
            resultado = ((30 + 8 -2)/2)* - 1;
            Console.WriteLine($"Resultado = {resultado}");
            //sesion 11: continuacion de resolucion de examen
            //Ejercicio #7: Interruptores
            bool interruptor_1 = false;
            bool interruptor_2 = true;
            if (interruptor_1 && interruptor_2)
            {
                bool Bombilla = true;
                Console.WriteLine($"Bombilla: {Bombilla}");
            }
            else
            {
               bool Bombilla = false;
               Console.WriteLine($"Bombilla: {Bombilla}");
               //Ejercicio #8: Asueto
                int Dia = 16;
                string mes = "Septiembre";
                if (Dia == 16 && mes == "Septiembre")
                {
                    Console.WriteLine("Asueto");
                }
                else
                {
                    Console.WriteLine("Sin definir");
                }
                //Ejercicio #9: Alamcenar
                bool Resultado = (11>7) && 9 != 0;
                Console.WriteLine($"Expresion: {Resultado}");
            }
        }
    }
}