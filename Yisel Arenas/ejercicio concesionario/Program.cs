using System;

namespace ejercicio_concesionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de dinero que deposita el primer cliente");
            int cliente1 = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Ingrese la cantidad de dinero que deposita el segundo cliente");
            int cliente2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de dinero que deposita el tercer cliente");
            int cliente3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("El deposito diario del primer cliente es: ");
                Console.WriteLine(cliente1);
            Console.WriteLine("\n");
                Console.WriteLine("El deposito diario del segundo cliente es: ");
                Console.WriteLine(cliente2);
            Console.WriteLine("\n");
            Console.WriteLine("El deposito diario del tercer cliente es: ");
                Console.WriteLine(cliente3);
            Console.WriteLine("\n");

            int deposito_diario = cliente1 + cliente2 + cliente3;
                Console.WriteLine("El deposito diario de todos los 3 clientes es: ");
                Console.WriteLine(deposito_diario);
            Console.WriteLine("\n");

            Console.WriteLine("Suponiendo que cada mes tiene un total de 30 dias");
            Console.WriteLine("\n");


            int deposito_mensual_cliente1 = cliente1 * 30;
                Console.WriteLine("El deposito mensual de el primer cliente es: ");
                Console.WriteLine(deposito_mensual_cliente1);
            Console.WriteLine("\n");

            int deposito_mensual_cliente2 = cliente2 * 30;
                Console.WriteLine("El deposito mensual de el segundo cliente es: ");
                Console.WriteLine(deposito_mensual_cliente2);
            Console.WriteLine("\n");

            int deposito_mensual_cliente3 = cliente3 * 30;
                Console.WriteLine("El deposito mensual de el tercer cliente es: ");
                Console.WriteLine(deposito_mensual_cliente3);
            Console.WriteLine("\n");

            Console.WriteLine("El deposito mensual total de los tres clientes es: ");
                int deposito_mensual = deposito_mensual_cliente1 + deposito_mensual_cliente2 + deposito_mensual_cliente3;
                Console.WriteLine(deposito_mensual);
        }
    }
}
