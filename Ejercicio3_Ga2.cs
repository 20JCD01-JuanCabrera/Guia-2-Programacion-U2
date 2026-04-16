internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Rango de estudiantes");
        Console.WriteLine("Ingrese una letra (A, B, C, D y F): ");
        char letra = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (letra)
        {
            
            case 'A':
                Console.WriteLine("Excelente");
                break;
            case 'B':
                Console.WriteLine("Bueno");
                break;
            case 'C':
                Console.WriteLine("Regular");
                break;
            case 'D':
                Console.WriteLine("Deficiente");
                break;
            case 'F':
                Console.WriteLine("Reprobado");
                break;
            default:
                Console.WriteLine("Escriba una letra valida");
                break;
        }
    }
}