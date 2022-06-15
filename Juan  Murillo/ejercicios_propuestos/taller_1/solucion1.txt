using System;
					
public class operaciones
{
	public static void Main()
	{
		//Crear 4 variables numéricas con el valor que tú quieras y guardarla en otra variable numérica imprimir por consola la suma, resta, la multiplicación y división de las posibles soluciones de las operaciones.
			//declaramos las variables con un valor prefijado
			double n1 = 4;
			double n2 = 6;
			double n3 = 12;
			double n4 = 34;
		Console.WriteLine("los datos que usamoe en esta practica son:\ndato1 : 4\ndato2 : 6\ndato3 : 12\ndato4 : 34");
		
		//declaramos las variables que operan las variables anteriores
		double suma = n1+n2+n3+n4;
		double resta1 = n1-n2;
		double resta2 = n2-n1;
		double resta3 = n3-n4;
		double resta4 = n4-n3;
		double multi = n1*n2*n3*n4;
		double divi1 = n1/n2;
		double divi2 = n2/n1;
		double divi3 = n3/n4;
		double divi4 = n4/n3;
		
		//imprimimos los resultados de las operaciones en pantalla
		Console.WriteLine("la suma de los cuatro datos es :"+suma);
		Console.WriteLine("la resta entre el dato 1 y el dato 2 es :"+ resta1);
		Console.WriteLine("la resta entre el dato 2 y el dato 1 es :"+ resta2);
		Console.WriteLine("la resta entre el dato 3 y el dato 4 es :"+ resta3);
		Console.WriteLine("la resta entre el dato 4 y el dato 3 es :"+ resta4);
		Console.WriteLine("la multicacion de los cuatro datos es :"+ multi);
		Console.WriteLine("la division entre el datos 1 y el dato 2 es :"+ Math.Round(divi1,2));
		Console.WriteLine("la division entre el datos 2 y el dato 1 es :"+ Math.Round(divi2,2));
		Console.WriteLine("la division entre el datos 3 y el dato 4 es :"+ Math.Round(divi3,2));
		Console.WriteLine("la division entre el datos 4 y el dato 3 es :"+ Math.Round(divi4,2));
		
		
	}
}
