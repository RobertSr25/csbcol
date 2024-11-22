internal class Program
{
    private static void Main(string[] args)
    {
        calcularNumero();
    }
    //Diseñar un programa que solicite al usuario dos números y, si el primer número es más grande,
    //calcule y muestre su suma y resta. De lo contrario, calculará y mostrará su producto y cociente.
    static void calcularNumero()
    {
        //declaramos las variables que vamos a utilizar
        double numero1 = 0;
        double numero2 = 0;
        double suma = 0;
        double resta = 0;
        double producto = 0;
        double cociente = 0;
        string valor = string.Empty;

        Console.WriteLine("Introduzca el valor de numero1 :");
        valor = Console.ReadLine();

        try
        {
            if (double.TryParse(valor, out numero1))
            {
                Console.WriteLine("Introduzca el valor de numero2 :");
                valor = Console.ReadLine();
                {
                    if (double.TryParse(valor, out numero2))
                    {
                        if (numero1 > numero2)
                        {
                            suma = numero1 + numero2;
                            resta = numero1 - numero2;
                            Console.WriteLine($"la sumatoria es: { suma } y la resta es: { resta } ");
                        }
                        else
                        {
                                producto = numero1 * numero2;
                                cociente = numero1 / numero2;
                                Console.WriteLine($"El producto es: {producto} y el cociente es: {cociente} ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("el formato del valor numero2 es invalido");
                    }
                }
            }
            else
            {
                Console.WriteLine("el formato de valor numero1 es invalido");
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error ejecutando la instruccion {ex}");
        }
    }
}