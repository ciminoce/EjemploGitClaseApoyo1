namespace EjemploGitClaseApoyo1.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int contadorTemperaturas = 1; contadorTemperaturas <= 5; contadorTemperaturas++)
            {
                Console.WriteLine($"Nro. Temperatura:{contadorTemperaturas}");
                Console.Write("Ingrese una temperatura entre -10 y 30:");
                var temperaturaCelsius = double.Parse(Console.ReadLine()!);

            }
        }
    }
}
