using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace CalculadoraGit
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                
                Console.WriteLine("=== Calculadora Git ===");

                Console.WriteLine("Ingrese el primer número:");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número:");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Seleccione la operación:");
                Console.WriteLine("1. Suma (+)");
                Console.WriteLine("2. Resta (-)");
                Console.WriteLine("3. Multiplicación (*)");
                Console.WriteLine("4. División (/)");

                string opcion = Console.ReadLine();

                double resultado = 0;

                // Aquí cada integrante agregará su operación

                else if (opcion == "4")
                {
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir para cero");
                        resultado = 0;
                    }
                }
                Console.WriteLine("Resultado: " + resultado);
                Console.WriteLine("¿Desea continuar? (S/N)");
                string resp = Console.ReadLine();
                continuar = resp.Equals("S", StringComparison.OrdinalIgnoreCase);
            }
        }
    }
}
