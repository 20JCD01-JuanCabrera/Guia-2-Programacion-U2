internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==== Calculadora de angulos ====");
        double g, op;
        Console.Write("Ingrese el valor del angulo en grados: ");
        g = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("==== Lista de opciones ====");
        Console.WriteLine("1- Seno");
        Console.WriteLine("2- Coseno");
        Console.WriteLine("3- Tangente");

        Console.WriteLine("Ingrese el numero de la opcion que desea: ");
        op = Convert.ToDouble(Console.ReadLine());

        double a = Math.Sin(g);
        double b = Math.Cos(g);
        double c = Math.Tan(g);

        switch (op)
        {
            case 1:
                Console.WriteLine("El seno del angulo es: "+a);
                break;
            case 2:
                Console.WriteLine("El coseno del angulo es: "+b);
                break;
            case 3:
                Console.WriteLine("La tangente del angulo es: "+c);
                break;
            default:
                break;
        }

    }
}