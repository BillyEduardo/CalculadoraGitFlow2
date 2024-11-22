using System;

namespace Calculadora
{
	public class Menu
	{
		public static void MostrarMenu()
		{
			Console.WriteLine("=== Calculadora ===");
			Console.WriteLine("1. Sumar");
			Console.WriteLine("2. Restar");
			Console.WriteLine("3. Multiplicar");
			Console.WriteLine("4. Dividir");
			Console.WriteLine("Seleccione una opción (1-4): ");
		}

		public static void ProcesarOpcion(int opcion)
		{
			switch (opcion)
			{
				case 1:
					Console.WriteLine("Has seleccionado Sumar.");
					break;
				case 2:
					Console.WriteLine("Has seleccionado Restar.");
					break;
				case 3:
					Console.WriteLine("Has seleccionado Multiplicar.");
					break;
				case 4:
					Console.WriteLine("Has seleccionado Dividir.");
					break;
				default:
					Console.WriteLine("Opción no válida.");
					break;
			}
		}
	}
}
