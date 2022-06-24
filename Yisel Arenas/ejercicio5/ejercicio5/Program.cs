// See https://aka.ms/new-console-template for more information
string[] datos = { "movRectilineoUniforme", "novRectilineoUniformeAcl", "movCirularUniforme"};

Console.WriteLine("Ingrese la velocidad final");
int velocidadFinal = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la velocidad inicial");
int velocidadInicial = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el tiempo final");
int tiempoFinal = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el tiempo inicial");
int tiempoInicial = Convert.ToInt32(Console.ReadLine());

string a = "a";
string b = "b";
string c = "c";



int aceleracion = (velocidadFinal - velocidadInicial / tiempoFinal);


Console.WriteLine("Escriba por favor que tipo de movimiento desea realizar siendo 'a' el movimiento rectilineo uniforme, 'b' el moviemiento rectilineo uniforme acelerado" +
    " y 'c' el movimiento circular uniforme");
string respuesta = Console.ReadLine();

if (respuesta == a)
{
    int movRectUni = (velocidadFinal / velocidadInicial) / (tiempoFinal * tiempoInicial * 2);
    Console.WriteLine("resultado del moviemiento rectilineo uniforme");
    Console.WriteLine(movRectUni);
}

else if (respuesta == b)
{
    int movRecUniac = velocidadFinal * tiempoInicial + 1 / 2 * aceleracion * tiempoFinal ^ 2;
    Console.WriteLine("resultado del moviemiento rectilineo uniforme acelerado");
    Console.WriteLine(movRecUniac);
}

else if (respuesta == c)
{
    int movCirUni = velocidadInicial + aceleracion * tiempoFinal;
    Console.WriteLine("resultado del moviemiento circular uniforme");
    Console.WriteLine(movCirUni);

}
