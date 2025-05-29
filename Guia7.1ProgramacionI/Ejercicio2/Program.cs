namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mpk, cms, cbd, cpq, ccj, sbd;

            Console.WriteLine("ingrese cantidad de masa");
            mpk = Convert.ToDouble(Console.ReadLine());

            mpk = mpk * 1000;
            cbd = mpk / 55;
            cms = mpk % 55;
            cpq = cbd / 12;
            ccj = cpq / 20;
            sbd = cbd - ccj * 20 * 12;

            Console.WriteLine("Cantidad de budines {0:f2}", cbd);
            Console.WriteLine("Masa Sobrante {0:f2}", cms);
            Console.WriteLine("Paquetes a hacer {0:f2}", cpq);
            Console.WriteLine("Cajas a completar {0:f2}", ccj);
            Console.WriteLine("Budines sobrantes ", sbd);

            Console.ReadKey();
        }
    }
}
