


using Consola.Class;

public class Program
{

    private static void Main(string[] args)
    {
        CreamosUnAlumnosEImprimimosSuFichaDeDatos();
        CreamosVariables();
        CreamosMtricesYVectores();
        Console.WriteLine("Rojo intracendente");
        ImpresionDeParametros(args);
        //CapturaValoresDelUsuario();
        
    }

    private static void CreamosUnAlumnosEImprimimosSuFichaDeDatos()
    {
        Alumno alumno = new Alumno("Juan", "Perez", 12345678, new DateOnly(2000, 1, 1));
        Console.WriteLine(alumno.ImpresionFichadeDatos());

        Alumno alumno1 = new Alumno("Maria", "Gomez", 87654321, new DateOnly(1999, 12, 31));
        Console.WriteLine(alumno1.ImpresionFichadeDatos());
        
        Alumno alumno2 = new Alumno("Luis", "Garcia", 11223344, new DateOnly(2001, 6, 15));
        Console.WriteLine(alumno2.ImpresionFichadeDatos());

        Console.WriteLine(Alumno.GetInstanciasDeAlumnos());
    }

    private static void CreamosMtricesYVectores()
    {
        //creamos un vector de 5 elementos
        string[] meses= new string[12] {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
        meses[0] = "ENERO";
        meses[11] = "DICIEMBRE";
        //creamos una matriz de tipo string de 3 filas y 2 columnas
        string[,] nosotros= new string[3,2] {{"Juan", "Pedro"}, {"Maria", "Luis"}, {"Ana", "Carlos"}};
        nosotros[0, 0] = "JUAN";
        nosotros[2, 1] = "GOMEZ";
        int[] edades = new int[3] { 20, 21, 22 };
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