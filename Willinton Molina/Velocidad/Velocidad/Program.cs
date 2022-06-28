﻿using System;

namespace Velocidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] movimiento = { "movimiento rectilíneo uniforme ", " movimiento rectilíneo uniforme acelerado ", " movimiento circular uniforme " };

            Console.WriteLine(" ----¡¡Bienvenido!!----  ");

            Console.WriteLine("Cuantas veces quiere repetir el programa");
            int buncle = int.Parse(Console.ReadLine());

            for (int i = 0; i < buncle; i++)
            {
                Console.WriteLine(" Que procedimiento desea hacer ");

                Console.WriteLine("-------");

                Console.WriteLine("1. Movimiento rectilíneo uniforme");

                Console.WriteLine("2. Movimiento rectilíneo uniforme acelerado");

                Console.WriteLine("3. Movimiento circular uniforme");

                int operaciones;

                operaciones = Convert.ToInt32(Console.ReadLine());

                switch (operaciones)
                {
                    case 1:
                        Mru();
                        break;
                    case 2:
                        Mrua();
                        break;
                    case 3:
                        Mcu();
                        break;
                }
            }
        }
        public static void Mru()
        {
            Console.WriteLine("Que magitud va a calcular");

            Console.WriteLine("------");

            Console.WriteLine("1.Distancia");

            Console.WriteLine("2.Velocidad");

            Console.WriteLine("3.Tiempo");

            int magnitud = Convert.ToInt32(Console.ReadLine());

            if (magnitud == 1)
            {
                Console.WriteLine("Se va a calcular la distancia");

                Console.WriteLine("---------");

                Console.WriteLine("-Ingrese la velocidad");
                double velocidad = double.Parse(Console.ReadLine());

                Console.WriteLine("-Ingrese la tiempo");
                double tiempo = double.Parse(Console.ReadLine());

                double distancia = velocidad * tiempo;

                Console.WriteLine($"La distancia es de {distancia} M");
            }
            if (magnitud == 2)
            {
                Console.WriteLine("Se va a calcular velocidad");

                Console.WriteLine("-Ingrese la distancia");
                double distancia = double.Parse(Console.ReadLine());

                Console.WriteLine("-Ingrese la tiempo");
                double tiempo = double.Parse(Console.ReadLine());

                double velocidad = distancia / tiempo;

                Console.WriteLine($"La distancia es de {velocidad} M/S");
            }
            if (magnitud == 3)
            {
                Console.WriteLine("Se va a calcular tiempo");

                Console.WriteLine("-Ingrese la distancia");
                double distancia = double.Parse(Console.ReadLine());

                Console.WriteLine("-Ingrese la velociad");
                double velocidad = double.Parse(Console.ReadLine());

                double tiempo = distancia / velocidad;

                Console.WriteLine($"La distancia es de {tiempo} Sg");
            }

        }

        static void Mrua()
        {
            Console.WriteLine("Que magitud va a calcular");

            Console.WriteLine("---");

            Console.WriteLine("1.Distancia");

            Console.WriteLine("2.Velocidad inicial");

            Console.WriteLine("3.Velocidad final");

            Console.WriteLine("4.Tiempo");

            Console.WriteLine("5.Aceleracion");

            int magnitud = Convert.ToInt32(Console.ReadLine());

            if (magnitud == 1)
            {
                Console.WriteLine("se va a calcular la distancia");

                Console.WriteLine("-Ingrese la velocidad inicial");

                double velocidad1 = double.Parse(Console.ReadLine());

                Console.WriteLine("-Ingrese la velocidad final");

                double velocidad2 = double.Parse(Console.ReadLine());

                Console.WriteLine("-Ingrese la tiempo");

                double tiempo = double.Parse(Console.ReadLine());

                double distancia = (velocidad1 + velocidad2) / 2 * tiempo;

                Console.WriteLine($"La distancia es de {distancia} M");
            }
            if (magnitud == 2)
            {
                Console.WriteLine("Se va a calcular la velocidad inicial ");

                Console.WriteLine("-Ingrese la velocidad final");
                double velocidad1 = double.Parse(Console.ReadLine());

                Console.WriteLine("-Ingrese la aceleracion");
                double aceleracion = double.Parse(Console.ReadLine());

                Console.WriteLine("-Ingrese la tiempo");
                double tiempo = double.Parse(Console.ReadLine());

                double velocidad = velocidad1 - aceleracion * tiempo;

                Console.WriteLine($"La velocidad inicial es de {velocidad} M/s");
            }
            if (magnitud == 3)
            {
                Console.WriteLine("Se va a calcular la velocidad final ");

                Console.WriteLine("-Ingrese la velocidad inicial");
                double velocidad1 = double.Parse(Console.ReadLine());

                Console.WriteLine("-Ingrese la aceleracion");
                double aceleracion = double.Parse(Console.ReadLine());

                Console.WriteLine("-Ingrese la tiempo");
                double tiempo = double.Parse(Console.ReadLine());

                double velocidad = velocidad1 + aceleracion * tiempo;

                Console.WriteLine($"La velocidad final es de {velocidad} M/s");
            }
            if (magnitud == 4)
            {
                Console.WriteLine("Se va a calcular el tiempo ");

                Console.WriteLine("-Ingrese la velocidad final");
                double velocidad2 = double.Parse(Console.ReadLine());

                Console.WriteLine("-Ingrese la velocidad inicial");
                double velocidad1 = double.Parse(Console.ReadLine());

                Console.WriteLine("-Ingrese la aceleracion");
                double aceleracion = double.Parse(Console.ReadLine());

                double tiempo = (velocidad2 - velocidad1) / aceleracion;

                Console.WriteLine($"El tiempo es de {tiempo} Sg");
            }
            if (magnitud == 5)
            {
                Console.WriteLine("Se va a calcular la aceleracion ");

                Console.WriteLine("-Ingrese la velocidad final");
                double velocidad2 = double.Parse(Console.ReadLine());

                Console.WriteLine("-Ingrese la velocidad inicial");
                double velocidad1 = double.Parse(Console.ReadLine());

                Console.WriteLine("-Ingrese la tiempo");
                double tiempo = double.Parse(Console.ReadLine());

                double aceleracion = (velocidad2 - velocidad1) / tiempo;

                Console.WriteLine($"El tiempo es de {aceleracion} M/S2");
            }
        }
        static void Mcu()
        {
            Console.WriteLine("Que magitud va a calcular");

            Console.WriteLine("-------");

            Console.WriteLine("1. Tiempo");

            Console.WriteLine("2. Longitud de arco");

            Console.WriteLine("3. Rapidez tangencial");

            int magnitud = Convert.ToInt32(Console.ReadLine());
            if (magnitud == 1)
            {
                Console.WriteLine("Se va a calcular el tiempo");

                Console.WriteLine("Ingrese la longitud del arco");
                double longitud = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese la rapidez tangencial");
                double rapidez = Convert.ToDouble(Console.ReadLine());

                double tiempo = longitud / rapidez;
                Console.WriteLine($" el resultado del tiempo es de: {tiempo} Sg");
            }
            if (magnitud == 2)
            {
                Console.WriteLine("Se va a calcular la longitud del arco");

                Console.WriteLine("Ingrese el tiempo");
                double tiempo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese la rapidez tangencial");
                double rapidez = Convert.ToDouble(Console.ReadLine());

                double arco = rapidez + tiempo;
                Console.WriteLine($" el resultado del la logitud del arco es de: {arco} M");
            }
            if (magnitud == 3)
            {
                Console.WriteLine("Se va a calcular la rapidez tangencial");

                Console.WriteLine("Ingrese el tiempo");
                double tiempo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese la longitud del arco");
                double lArco = Convert.ToDouble(Console.ReadLine());

                double rtangencial = lArco + tiempo;
                Console.WriteLine($" El resultado de la raidez tangencial es de: {rtangencial} M/s");
            }
        }
    }
}