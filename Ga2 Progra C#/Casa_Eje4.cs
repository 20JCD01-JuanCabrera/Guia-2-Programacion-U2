internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n**********Menu Principal**********");
        Console.WriteLine("1 - Hamburguesa");
        Console.WriteLine("2 - Pizza");
        Console.WriteLine("3 - Pollo Frito");
        Console.WriteLine("4 - Ensalada");
        Console.WriteLine("5 - Salir");
        Console.WriteLine("Digite un menu segun su opcion: ");
        int opc = Convert.ToInt32(Console.ReadLine());

        //EVALUAR CON SWITCH
     
        switch (opc)
        {
            case 1:

                Console.WriteLine("Usted a solicitado --->");
                Console.WriteLine("Hamburguesa");
                break;
            case 2:
                Console.WriteLine("Usted a solicitado --->");
                Console.WriteLine("Pizza");
                break;
            case 3:
                Console.WriteLine("Usted a solicitado --->");
                Console.WriteLine("Pollo Frito");
                break;
            case 4:
                Console.WriteLine("Usted a solicitado --->");
                Console.WriteLine("Ensalada");
                break;
            case 5:
                Console.WriteLine("Saliendo del sistema...");
                break;
            default:
                Console.WriteLine("Seleccione una menu Valida!!!");
                break;

        }
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Green;
    }
}