


public class Program
{

    private static void Main(string[] args)
    {
        CreamosVariables();
       Console.WriteLine("Rojo puto");
        ImpresionDeParametros(args);
        CapturaValoresDelUsuario();
    }

    private static void CapturaValoresDelUsuario()
    {
        Console.Write("Escriba el año de su nacimiento: ");
        string Nacimiento = Console.ReadLine();
        int anio= Convert.ToInt32(Nacimiento);
        int edad = DateTime.Now.Year - anio;
        Console.WriteLine("Tu edad puede ser: " + edad);
    }

    private static void ImpresionDeParametros(string[] args)
    {
        if (args.Length > 1)
            Console.WriteLine("hoal " + args[0] + " " + args[1]);
    }

    private static void CreamosVariables()
    {
        //creamos una variable int y le asignamos un valor
        int numero = 10;
        //declaracion
        int numero2;
        //asignacion
        numero2 = 20;
        int numero3 = 30;

    }
}