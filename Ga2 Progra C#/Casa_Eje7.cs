internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===== Identificador de caracter =====");


        Console.WriteLine("Ingrese un caracter: ");
        char a = char.ToLower(Console.ReadKey().KeyChar);

        switch (a)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("\nEl caracter es una vocal.");
                break;
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
                Console.WriteLine("El caracter es un dígito.");
                break;
            default:
                Console.WriteLine("El caracter no es ni una vocal ni un dígito.");
                break;
        }
    }
}