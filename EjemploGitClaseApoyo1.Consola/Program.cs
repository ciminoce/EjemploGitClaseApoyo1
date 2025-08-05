using System.Runtime.CompilerServices;

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

                var temperaturaCelsius = ObtenerValorDouble("Ingrese la temperatura entre -10 y 30 grados celsius:",-10,30);

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
        private static double ObtenerValorDouble(string mensaje, double valorMin, double valorMax)
        {
            double valor = 0.0;
            do
            {
                Console.Write(mensaje);
                if(!double.TryParse(Console.ReadLine(), out valor) || valor<valorMin || valor>valorMax)
                {
                    Console.WriteLine("Temperatura mal ingresada o fuera del rango");
                }
                else
                {
                    break;
                }

            } while (true);
            return valor;
        }
    }
}
