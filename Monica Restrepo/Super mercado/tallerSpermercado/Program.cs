using System;

namespace tallerSpermercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a Super Mercado la Plazita\n");

            Console.WriteLine("Ingrese El nombre\n ");

            string nom = Console.ReadLine();

            Console.WriteLine("Ingrese el sexo F si es mujer M si es hombre\n ");

            string sexo = Console.ReadLine();

            Console.WriteLine("Cuentos hijos tiene\n ");

            int hijo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el monto total de la compra\n ");

            int monto = Convert.ToInt32(Console.ReadLine());

            double total;

            if (sexo=="M" && hijo==0)
            {
                total = monto-((monto*2.5)/100);

                Console.WriteLine("Señor " + nom + " El subtotal de la compra es " + monto 
                    + "\nAl cual se le aplico un descuento del 2.5%" 
                    + "\nEl monto final de la compra es " + total);
            }

            else if (sexo == "M" && hijo >=1)
            {
                total = monto - ((monto * 5) / 100);

                Console.WriteLine("Señor " + nom + " El subtotal de la compra es " + monto
                    + "\nAl cual se le aplico un descuento del 5% "
                    + "\nEl monto final de la compra es " + total);
            }

            else if (sexo == "F" && hijo == 0)
            {
                total = monto - ((monto * 10) / 100);

                Console.WriteLine("Señorita " + nom + " El subtotal de la compra es " + monto
                    + "\nAl cual se le aplico un descuento del 10% "
                    + "\nEl monto final de la compra es " + total);
            }

            else if (sexo == "F" && hijo==1 || hijo==2)
            {
                total = monto - ((monto * 15) / 100);

                Console.WriteLine("Señora " + nom + " El subtotal de la compra es " + monto
                    + "\nAl cual se le aplico un descuento del 15% "
                    + "\nEl monto final de la compra es " + total);
            }

            else if (sexo == "F" && hijo >= 3)
            {
                total = monto - ((monto * 20) / 100);

                Console.WriteLine("Señora " + nom + " El subtotal de la compra es " + monto
                    + "\nAl cual se le aplico un descuento del 20% "
                    + "\nEl monto final de la compra es " + total);
            }



        }
    }
}
