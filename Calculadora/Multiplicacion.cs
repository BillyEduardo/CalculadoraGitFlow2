using System;

namespace Calculadora
{
	public class Multiplicacion
	{
		// Método para realizar la multiplicación de dos números
		public static void RealizarMultiplicacion()
		{
			Console.WriteLine("Has seleccionado Multiplicar.");

			// Solicitar los dos números al usuario
			Console.Write("Ingresa el primer número: ");
			double numero1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Ingresa el segundo número: ");
			double numero2 = Convert.ToDouble(Console.ReadLine());

			// Realizar la multiplicación
			double resultado = numero1 * numero2;

			// Mostrar el resultado
			Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
		}
	}
}
