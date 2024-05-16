using System;

namespace TipoDeAngulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce los grados del ángulo:");
            double grados = double.Parse(Console.ReadLine());

            if (grados < 90)
            {
                Console.WriteLine("El ángulo es agudo.");
            }
            else if (grados > 90)
            {
                Console.WriteLine("El ángulo es obtuso.");
            }
            else if (grados == 90)
            {
                Console.WriteLine("El ángulo es recto.");
            }
            else
            {
                Console.WriteLine("Valor no válido. Introduce un número válido para los grados del ángulo.");
            }

            // Mantener la consola abierta
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
