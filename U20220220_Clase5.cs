
  using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            // DECLARACION DE VARIABLES

            // DECLARACION DE VARIABLES DE TIPO TEXTO CON CAPTURA DESDE CONSOLA

            string? universidad="";

            // DECLARACION DE VARIABLES DE TIPO TEXTO CON ASIGNACION DESDE CODIGO

            string facultad="Ingenieria y Arquitectura";
            string profecion="Tecnico en desarrollo de software";

            // DECLARACION DE VARIABLES DE TIPO ENTERO CON CAPTURA DESDE CONSOLA

            int AñoIngreso=0;

            // DECLARACION DE VARIABLES DE TIPO ENTERO CON ASIGNACION DESDE CODIGO

            int edadIngreso=20;
            int edadEgreso=22;

            // DECLRACION DE VARIABLES DE TIPO DOUBLE CON CAPTURA DESDE CONSOLA

            double cuotaU=0;

            //DECLARACION DE VARIABLES DE TIPO DOUBLE CON ASIGNACION DESDE CODIGO

            double gastoTransporte=1.15;

            Console.WriteLine("\n----------------------------------------------------------\n");

            // CAPTURA DE DATOS DESDE CONSOLA

            Console.WriteLine("\n----------------------------------------------------------\n");
            Console.WriteLine("\n---------------captura de datos de tipo texto---------------");
            Console.WriteLine("En que universidad estudia");
            universidad=Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n----------------fin de captura de tipo texto--------------\n");

            Console.WriteLine("\n----------------------------------------------------------\n");
            Console.WriteLine("\n---------------captura de datos de tipo entero---------------");
            Console.WriteLine("En que año ingreso");
            AñoIngreso=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n----------------fin de captura de tipo entero--------------\n");

            Console.WriteLine("\n----------------------------------------------------------\n");
            Console.WriteLine("\n---------------captura de datos de tipo double---------------");
            Console.WriteLine("Ingrese la cuota de la universidad");
            cuotaU=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n----------------fin de captura de tipo double--------------\n");

            // IMPRESION DE DATOS DESDE CONSOLA

            Console.WriteLine("\n----------------------------------------------------------\n");
            Console.WriteLine("\n---------------captura de datos de tipo texto---------------");
            Console.WriteLine("En que universidad estudia " + universidad);
            Console.WriteLine("A que faultad pertenece " + facultad);
            Console.WriteLine("Cual es su profecion " + profecion);
            Console.WriteLine("\n----------------------------------------------------------\n");

            Console.WriteLine("\n----------------------------------------------------------\n");
            Console.WriteLine("\n---------------captura de datos de tipo entero---------------");
            Console.WriteLine("En que año ingreso " + AñoIngreso);
            Console.WriteLine("su edad en la que ingreso es de " + edadIngreso + " años" );
            Console.WriteLine("su edad en la que egresara es de " + edadEgreso + " años");
            Console.WriteLine("\n----------------------------------------------------------\n");

            Console.WriteLine("\n----------------------------------------------------------\n");
            Console.WriteLine("\n---------------captura de datos de tipo double---------------");
            Console.WriteLine("Ingrese la cuota de la universidad" + " $" + cuotaU);
            Console.WriteLine("Gasto de transporte" + " $" + gastoTransporte);

            Console.ReadKey();


        }
    }
}