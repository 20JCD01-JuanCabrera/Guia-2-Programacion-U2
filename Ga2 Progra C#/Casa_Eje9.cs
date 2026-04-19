using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==== Conversor de medidas ====");
        Console.WriteLine("==== Opciones ====");
        Console.WriteLine("1- Metros");
        Console.WriteLine("2- Pies");
        Console.WriteLine("3- Centimetros");
        Console.WriteLine("4- Pulgadas");

        Console.WriteLine("Ingrese la opcion de medida de origen:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la longitud:");   
        double b = Convert.ToDouble(Console.ReadLine());

        double x;
        
        switch (a) {
            case 1:
                x = b;
                break;
            case 2:
                x = b / 3.281;
                break;
            case 3:
                x = b / 100;
                break;
            case 4:
                x = b / 39.37;
                break;
            default: 
                Console.WriteLine("Opcion no valida");
                                return;
        }

        Console.WriteLine("Digite la opcion de medida a la que quiere convertir:");
        int c = Convert.ToInt32(Console.ReadLine());

        switch (c) {
            case 1:
                Console.WriteLine($"{b} en metros es: {x}");
                break;
            case 2:
                Console.WriteLine($"{b} en pies es: {x * 3.281}");
                break;
            case 3:
                Console.WriteLine($"{b} en centimetros es: {x * 100}");
                break;
            case 4:
                Console.WriteLine($"{b} en pulgadas es: {x * 39.37}");
                break;
            default: 
                Console.WriteLine("Opcion no valida");
                                return;
        }
    }
}