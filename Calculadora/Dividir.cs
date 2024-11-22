using System;

namespace Calculadora
{
	public class Division
	{
		// Método para realizar la división de dos números
		public static void RealizarDivision()
		{
			Console.WriteLine("Has seleccionado Dividir.");

			// Solicitar los dos números al usuario
			Console.Write("Ingresa el primer número (dividendo): ");
			double numero1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Ingresa el segundo número (divisor): ");
			double numero2 = Convert.ToDouble(Console.ReadLine());

			// Validar que el divisor no sea cero
			if (numero2 == 0)
			{
				Console.WriteLine("Error: No se puede dividir entre cero.");
			}
			else
			{
				// Realizar la división
				double resultado = numero1 / numero2;

				// Mostrar el resultado
				Console.WriteLine($"El resultado de la división es: {resultado}");
			}
		}
	}
}
