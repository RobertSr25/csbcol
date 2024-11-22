using System.ComponentModel.Design;
using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        calcularPromedioCalificacion();
    }
    //Leer tres calificaciones y calcular el promedio.
    //Si el promedio es igual o superior a siete, imprimir un mensaje indicando que el alumno ha aprobado.
    static void calcularPromedioCalificacion()
    {
        int nota = 0;
        int cantidadNota = 0;
        int promedio = 0;
        int suma = 0;
        string valor =string.Empty; 

        Console.WriteLine("Introduzca la cantidad de notas para validar");
        valor = Console.ReadLine();

        try
        {
            if (int.TryParse(valor, out cantidadNota))
            {
                for (int i = 1; i <= cantidadNota; i++)
                {
                    Console.WriteLine($"Introduzca la nota {i}");
                    valor = Console.ReadLine();

                    if (int.TryParse(valor, out nota))
                    {
                        suma+=nota;
                    }
                    else
                    {
                        Console.WriteLine("formato de valor nota invalido");
                    }
                }
                    promedio = suma / cantidadNota;
                    if (promedio >= 7)
                    {
                    Console.WriteLine($"el promedio es { promedio } Felicidades usted ha aprobado el curso");
                    }
                    else
                    {
                    Console.WriteLine($"El promedio es: {promedio}debe repetir la asignatura");
                    }
            }
            else
            {
                Console.WriteLine("el formato de la cantidad de notas en invalida");
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error ejecutando la instruccion,verifique");
        }
    }
}