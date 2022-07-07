using System;

namespace ejercicio_supermercado
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            Console.WriteLine("Bienenid@ a su supermercado favorito; por favor ingrese su primer nombre y apellido :) ");
            string name = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Por favor elija el genero con el que se siente identificado(a), siendo 1 masculino y 2 femenino");
            int client = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("\n");

            Console.WriteLine("Por favor ingrese cuantos hijos tiene y en caso de no tener ningun hijo colocar 0 ");
            int children = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Por favor ingrese el monto total de su compra");
            int monto = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine ("\n");

            if (client == 1 && children == 0)
            {
                double descuento = 2.5;
                int total = monto-(int)(monto*descuento) / 100;

                Console.WriteLine("Señor " + name + " su monto inicial era de " + monto + " y su descuento fue un total del " + descuento + "%" + " de su compra, asi que su total a pagar es " + total);
                Console.WriteLine("\n");
            }

            else if (client == 1 && children >= 1)
            {
                int descuento = 5;
                int total = monto-((descuento*monto) / 100);

                Console.WriteLine($"Señor  {name} su monto inicial era de  {monto}  y su descuento fue un total del {descuento}% de su compra, asi que su total a pagar es  {total}");
                Console.WriteLine("\n");
            }

            else if (client == 2 && children == 0)
            {
                int descuento = 10;
                int total = monto-(monto*descuento) / 100;

                Console.WriteLine("Señorita " + name + " su monto inicial era de " + monto + " y su descuento fue un total del " + descuento + "%"  + " de su compra, asi que su total a pagar es " + total);
                Console.WriteLine("\n");
            }

            else if (client == 2 && children == 1 || children == 2)
            {
                int descuento = 15;
                int total = monto-(monto*descuento) / 100;

                Console.WriteLine("Señora " + name + " su monto inicial era de " + monto + " y su descuento fue un total del " + descuento + "%"  + " de su compra, asi que su total a pagar es " + total);
                Console.WriteLine("\n");
            }

             else
                {
                    Console.WriteLine("!!ERROR!!!");
                }
            }
        }
}

