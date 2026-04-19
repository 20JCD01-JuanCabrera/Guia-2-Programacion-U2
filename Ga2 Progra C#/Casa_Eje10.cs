internal class Program
{
    private static void Main(string[] args)
    {
        double a, b, i, it, c;
        Console.WriteLine("==== T&S, S.A de C.A ====");
        Console.WriteLine("==== Impresoras a Q.650.00 C/U (Sin IVA) ====");
        Console.WriteLine("==== Formas de pago ==== Descuento====");
        Console.WriteLine("      1- Efectivo           10%");
        Console.WriteLine("2- Tarjeta de crédito       5%");
        Console.WriteLine("   3- Vale de regalo        15%");

        Console.WriteLine("Digite la opcion de pago que desea: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite la cantidad de impresoras que desea comprar: ");
        b = Convert.ToDouble(Console.ReadLine());

        i = 650 * 0.12;
        it = 650 + i;

        switch (a)
        {

            case 1:
                Console.WriteLine("La cantidad de impresoras que va a comprar es de: "+ b);
                Console.WriteLine("El precio unitario de la impresora (con IVA) es: " + (it));
                Console.WriteLine("El total sin descuento es: " + (it * b));
                Console.WriteLine("La forma de pago sera en Efectivo");
                Console.WriteLine("El descuento realizado es de: " + ((it * b) * 0.10));
                Console.WriteLine("El total a pagar es de: "+ ((it * b) - (((it * b) * 0.10))));
                break;
            case 2:
                Console.WriteLine("La cantidad de impresoras que va a comprar es de: " + b);
                Console.WriteLine("El precio unitario de la impresora (con IVA) es: " + (it));
                Console.WriteLine("El total sin descuento es: " + (it * b));
                Console.WriteLine("La forma de pago sera con Tarjeta de credito");
                Console.WriteLine("El descuento realizado es de: " + ((it * b) * 0.05));
                Console.WriteLine("El total a pagar es de: " + ((it * b) - (((it * b) * 0.05))));
                break;
            case 3:
                Console.WriteLine("La cantidad de impresoras que va a comprar es de: " + b);
                Console.WriteLine("El precio unitario de la impresora (con IVA) es: " + (it));
                Console.WriteLine("El total sin descuento es: " + (it * b));
                Console.WriteLine("La forma de pago sera con Vale de regalo");
                Console.WriteLine("El descuento realizado es de: " + ((it * b) * 0.15));
                Console.WriteLine("El total a pagar es de: " + ((it * b) - (((it * b) * 0.15))));
                break;
            default:
                Console.WriteLine("Digite una opcion valida");
                break;
        }
    }

}
