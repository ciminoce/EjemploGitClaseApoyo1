namespace EjemploGitClaseApoyo1.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int contadorTemperaturas = 1; contadorTemperaturas <= 5; contadorTemperaturas++)
            {
                Console.WriteLine($"Nro. Temperatura:{contadorTemperaturas}");
                Console.WriteLine($"Nombre del dia: {InformarDiaSemana(contadorTemperaturas)}");
                Console.Write("Ingrese una temperatura entre -10 y 30:");
                var temperaturaCelsius = double.Parse(Console.ReadLine()!);

            }
        }
        private static string InformarDiaSemana(int nroDia)
        {
            switch (nroDia)
            {
                case 1:
                    return "Lunes";
                case 2:
                    return "Martes";
                case 3:
                    return "Miércoles";
                case 4:
                    return "Jueves";
                case 5:
                    return "Viernes";
                default:

                    return "Día no válido";
            }
        }
    }
}
