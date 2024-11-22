using System;

namespace Calculadora
{
	public class Suma
	{
		
		public static void RealizarSuma()
		{
			Console.WriteLine("Has seleccionado Sumar.");

			// Solicitar los dos números al usuario
			Console.Write("Ingresa el primer número: ");
			double numero1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Ingresa el segundo número: ");
			double numero2 = Convert.ToDouble(Console.ReadLine());

			// Realizar la suma
			double resultado = numero1 + numero2;

			// Mostrar el resultado
			Console.WriteLine($"El resultado de la suma es: {resultado}");
		}
	}
}
