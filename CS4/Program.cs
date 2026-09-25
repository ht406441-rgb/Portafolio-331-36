
using System;
using System.Data;
namespace CS4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sesion 8: Estructuras selectivas: dobles y multiples
            // 1. Estructura selectiva doble (Instruccion if-else)
            // Declaracion y inicializacion
            bool foco = false;
            if (foco == true)
            {
                Console.WriteLine("El foco esta encendido.");
            }
            else
            {
                Console.WriteLine("El foco esta apagado.");
            }
            // 2. Estructura selectiva multiple (Instruccion if-else if-else)
            // Declaracion y inicializacion
            int salon = 331;
            if (salon == 331)
            {
                Console.WriteLine("Exactas");
            }
            else if (salon == 332 || salon == 333)
            {
                Console.WriteLine("Administrativas");
            }
            /*
            else if (salon ==333)
            {
                Console.WriteLine("Administrativas");
            }
            */
            else if (salon == 334)
            {
                Console.WriteLine("Humanidades");
            }
            else if (salon == 335)
            {
                Console.WriteLine("Biologicas");
            }
            else
            {
                Console.WriteLine("Salon no registrado!");
            }
            // Sesion 7: Estructuras selectivas
            // a. Simple: Instruccion if
            int a = 0;
            int b = 1;
            if (a == 1) // SI el valor de a es igual a 1, entonces...
            {
               // Bloque de Instrucciones
               Console.WriteLine("El valor de a es igual a 1.");
               a += 1;
               Console.WriteLine($"a: {a}");
            }
            else
            Console.WriteLine("El valor de b es igual a 1.");
            // b. Doble: Instrucciones if-else
            // c. Multiple: Instrucciones if-else if-else
        }
    }
}