namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Defino variables
            double total, mn1, mn2, mn3, mn4, porcion;

            int en1, en2, en3, en4, sumed;
            #endregion

            #region Ingreso Datos
            Console.WriteLine("Ingrese total a distribuir");

            total = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese edades de las niñas");

            en1 = Convert.ToInt32(Console.ReadLine());
            en2 = Convert.ToInt32(Console.ReadLine());
            en3 = Convert.ToInt32(Console.ReadLine());
            en4 = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region Realizo Operaciones
            sumed = en1 + en2 + en3 + en4;

            porcion = total / sumed;

            mn1 = en1 * porcion;
            mn2 = en2 * porcion;
            mn3 = en3 * porcion;
            mn4 = en4 * porcion;
            #endregion

            #region Muestro Resultados
            Console.WriteLine("montos a distribuir:");
            Console.WriteLine("para la primera nieta: {0:f2}", mn1);
            Console.WriteLine("para la segunda nieta: {0:f2}", mn2);
            Console.WriteLine("para la tercera nieta: {0:f2}", mn3);
            Console.WriteLine("para la cuarta nieta: {0:f2}", mn4);

            Console.ReadKey();
            #endregion
        }
    }
}
