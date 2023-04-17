namespace Calculadora2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese valor 1");
            string value1 = Console.ReadLine();
            int value1Number = Int32.Parse(value1);

            Console.WriteLine("Ingrese valor 2");
            string value2 = Console.ReadLine();
            int value2Number = Int32.Parse(value2);

            // Sumar Números

            Console.WriteLine($"La suma es = {value1Number + value2Number}");

            // Restar Números

            Console.WriteLine($"La resta es = {value1Number - value2Number}");

            // Multiplicar Números

            Console.WriteLine($"La multiplicación es = {value1Number * value2Number}");

            // Dividir Números

            Console.WriteLine($"La división es = {value1Number / value2Number}");

            // Potencializar Números

            double valor, potencia, resultado;

            valor = value1Number;
            potencia = value2Number;
            resultado = Math.Pow(valor, potencia);

            Console.WriteLine($"La potenciación es = {resultado}");

            // Raiz cuadrada

            double resultado2, resultado3;


            resultado2 = Math.Sqrt(value1Number);
            resultado3 = Math.Sqrt(value2Number);

            Console.WriteLine($"La raíz cuadrada es del primer valor es = {resultado2}");
            Console.WriteLine($"La raíz cuadrada es del segundo valor es = {resultado2}");
            /* FIN */
        }
    }
}
