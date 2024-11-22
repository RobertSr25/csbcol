internal class Program
{
    private static void Main(string[] args)
    {
        calcularNivelPostulante();
    }
    //Desarrollar un programa que calcule el nivel de un postulante a partir de los resultados de un test.
    //El programa recibirá como entrada el número total de preguntas y las respuestas correctas, y devolverá un nivel según el porcentaje de aciertos.
    //Nivel máximo: Porcentaje>=90%.Nivel medio: Porcentaje>=75% y<90%.Nivel regular: Porcentaje>=50% y<75%.Fuera de nivel: Porcentaje<50%.
    static void calcularNivelPostulante()
    {
        double totalPreguntas = 0;
        double totalRespuestasCorrectas = 0;
        string nivel;
        double porcentaje = 0;
        string valor =string.Empty;

        Console.WriteLine("Introduzca la cantidad de preguntas a realizar");
        valor = Console.ReadLine();

        try
        {
            if (double.TryParse(valor, out totalPreguntas))
            {
                Console.WriteLine("Introduzca la cantidad de respuestas");
                valor = Console.ReadLine();

                if (double.TryParse(valor, out totalRespuestasCorrectas))
                {
                    porcentaje = (totalRespuestasCorrectas / totalPreguntas) * 100;

                    if (porcentaje >= 90)
                    {
                        nivel = "Nivel Maximo";
                    }
                    else if (porcentaje >= 75 && porcentaje < 90)
                    {
                        nivel = "Nivel Medio";
                    }
                    else if (porcentaje >= 50 && porcentaje < 75)
                    {
                        nivel = "Nivel regular";
                    }
                    else
                    {
                        nivel = "Fuera de nivel";
                    }
                    Console.WriteLine($"El porcentaje de aciertos es {porcentaje} para un: {nivel}");
                }
                else
                {
                    Console.WriteLine("formato de total respuestas invalido o no puede tener cero respuestas");
                }
            }
            else
            {
                Console.WriteLine("formato total de preguntas invalido");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error ejecutando la instruccion { ex }");
        }   

    }
}