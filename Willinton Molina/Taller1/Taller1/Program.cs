using System;

namespace Taller1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            Console.WriteLine("Ingrese su Nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Apellido");
            apellido = Console.ReadLine();
            saludo(nombre, apellido);



        }
        public static void saludo(string nombre, string apellido)
        {


            Console.WriteLine($"Bienvenido sea Señor {nombre}, {apellido} disfrute de su día");
        }
    }
}

