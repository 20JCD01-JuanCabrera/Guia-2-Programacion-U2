internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==== Meses del año ====");

        int d;
        Console.WriteLine("Digite el numero del mes del año: ");
        d = Convert.ToInt32(Console.ReadLine());

        switch (d)
            {
            case 1:
                Console.WriteLine("Es el mes de enero y tiene 31 dias");
                break;
            case 2:
                Console.WriteLine("Es el mes de febrero y tiene 28 o 29 dias");
                break;
            case 3:
                Console.WriteLine("Es el mes de marzo y tiene 31 dias");
                break;
            case 4:
                Console.WriteLine("Es el mes de abril y tiene 30 dias");
                break;
            case 5:
                Console.WriteLine("Es el mes de mayo y tiene 31 dias");
                break;
            case 6:
                Console.WriteLine("Es el mes de junio y tiene 30 dias");
                break;
            case 7:
                Console.WriteLine("Es el mes de julio y tiene 31 dias");
                break;
            case 8:
                Console.WriteLine("Es el mes de agosto y tiene 31 dias");
                break;
            case 9:
                Console.WriteLine("Es el mes de septiembre y tiene 30 dias");
                break;
            case 10:
                Console.WriteLine("Es el mes de octubre y tiene 31 dias");
                break;
            case 11:
                Console.WriteLine("Es el mes de noviembre y tiene 30 dias");
                break;
            case 12:
                Console.WriteLine("Es el mes de diciembre y tiene 31 dias");
                break;
            default:
                Console.WriteLine("Digite un numero valido");
                break;
        }
    }
}