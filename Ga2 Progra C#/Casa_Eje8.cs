internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==== Estadio Doroteo Guamuch Flores ====");
        Console.WriteLine("==== Opciones de Entrada ====");
        Console.WriteLine("1- Palco: Q.300.00");
        Console.WriteLine("2- Tribuna: Q100.00 - Q125.00");
        Console.WriteLine("3- Preferencia: Q50.00 - Q75.00");
        Console.WriteLine("4- Generales: Q30.00 - Q50.00");

        Console.WriteLine("Ingrese el número de la opción de entrada que desea comprar: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad de entradas que desea comprar: ");
        int b = Convert.ToInt32(Console.ReadLine());

        switch (a)
        {
            case 1:
                Console.WriteLine("El total a pagar es: ");
                Console.WriteLine("Ubicacion: Palco");
                Console.WriteLine("Ebtradas : " + b);
                Console.WriteLine("El total a pagar es: Q."+(300 * b));
                break;
            case 2:
                Console.WriteLine("El total a pagar es: ");
                Console.WriteLine("Ubicacion: Tribuna");
                Console.WriteLine("Ebtradas : " + b);
                Console.WriteLine("El total a pagar es: Q." + (100 * b));
                break;
            case 3:
                Console.WriteLine("El total a pagar es: ");
                Console.WriteLine("Ubicacion: Preferencia");
                Console.WriteLine("Ebtradas : " + b);
                Console.WriteLine("El total a pagar es: Q." + (50 * b));
                break;
            case 4:
                Console.WriteLine("El total a pagar es: ");
                Console.WriteLine("Ubicacion: General");
                Console.WriteLine("Ebtradas : " + b);
                Console.WriteLine("El total a pagar es: Q." + (30 * b));
                break;
                

            default:
                Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 4.");
                break;
        }
    }
}