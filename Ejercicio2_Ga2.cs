internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escriba dos valores numericos: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n**********Menu Principal**********");
        Console.WriteLine("1 - Suma");
        Console.WriteLine("2 - Resta");
        Console.WriteLine("3 - Multiplicacion");
        Console.WriteLine("4 - Division");
        Console.WriteLine("5 - Salir");
        Console.WriteLine("Digite un valor segun sea la operacion: []");
        int opc = Convert.ToInt32(Console.ReadLine());

        //EVALUAR CON SWITCH
        String msj = "";
        double res =0;
        switch (opc)
        {
            case 1:
                
                msj = "\nSuma\n La suma es: ";
                res = num1 + num2;
                break;
            case 2:
                msj = "\nResta\n La resta es: ";
                res = num1 - num2;
                break;
            case 3:
                msj = "\nMultiplicacion\n La multiplicacion es: ";
                res = num1 * num2;
                break;
            case 4:
                msj = "\nDivision\n La division es: ";
                res = num1 / num2;
                break;
            case 5:
                msj = "\nSaliendo del programa...";
                break;
            default:
                msj = "Digite una opcion valida!!!";
                break;

        }
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(msj);
        Console.WriteLine(res);

    }
}