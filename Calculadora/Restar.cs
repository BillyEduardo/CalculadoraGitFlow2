using System;

namespace Calculadora
{
	public class Resta
	{
		// Método para realizar la resta de dos números
		public static void RealizarResta()
		{
			Console.WriteLine("Has seleccionado Restar.");

			// Solicitar los dos números al usuario
			Console.Write("Ingresa el primer número: ");
			double numero1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Ingresa el segundo número: ");
			double numero2 = Convert.ToDouble(Console.ReadLine());

			// Realizar la resta
			double resultado = numero1 - numero2;

			// Mostrar el resultado
			Console.WriteLine($"El resultado de la resta es: {resultado}");
		}
	}
}
