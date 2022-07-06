using System;

namespace taller_autos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Concesionario Auto Plus\n\n");

            

            Console.WriteLine("Ingrese el deposito diario del cliente 1");
            double cliente1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el deposito diario del cliente 2");
            double cliente2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el deposito diario cliente 3");
            double cliente3 = Convert.ToInt32(Console.ReadLine());

            double sumam = cliente1 + cliente2 + cliente3;
            double sumat = sumam * 30;
            double suma1 = cliente1 * 30;
            double suma2 = cliente2 * 30;
            double suma3 = cliente3 * 30;

            Console.WriteLine("El deposito total de los tres clientes por dia es:\n\n " + sumam);
            Console.WriteLine("El deposito total de los tres clientes por mes es:\n\n " + sumat);
            Console.WriteLine("El deposito total del cliente 1 al mes es:\n\n " + suma1);
            Console.WriteLine("El deposito total del cliente 2 al mes es:\n\n " + suma2);
            Console.WriteLine("El deposito total del cliente 3 al mes es:\n\n " + suma3);
        }
    }
}
