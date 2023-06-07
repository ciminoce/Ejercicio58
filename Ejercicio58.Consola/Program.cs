namespace Ejercicio58.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int valorInicial = 0, valorFinal = 0;
            int sumaNumero = 0, cantidadImpares = 0;
            do
            {
                Console.Write("Ingrese el valor inicial del intervalo:");
                var str = Console.ReadLine();
                if (int.TryParse(str, out valorInicial))
                {
                    break;
                }
                Console.WriteLine("Número no válido");

            } while (true);

            do
            {
                Console.Write("Ingrese el valor final del intervalo:");
                var str = Console.ReadLine();
                if (int.TryParse(str, out valorFinal))
                {
                    break;
                }
                Console.WriteLine("Número no válido");

            } while (true);
            if (valorInicial < valorFinal)
            {
                for (int numero = valorInicial; numero <= valorFinal; numero++)
                {
                    if (EsPar(numero))
                    {
                        sumaNumero += numero;
                    }
                    else
                    {
                        cantidadImpares++;
                    }
                }

            }
            else
            {
                for (int numero = valorInicial; numero >=valorFinal; numero--)
                {
                    if (EsPar(numero))
                    {
                        sumaNumero += numero;
                    }
                    else
                    {
                        cantidadImpares++;
                    }
                }

            }
            Console.WriteLine($"La suma de los pares es {sumaNumero}");
            Console.WriteLine($"La cantidad de nros impares es {cantidadImpares}");
        }
        private static bool EsPar(int nro)
        {
            return nro % 2==0;
        }
    }
}