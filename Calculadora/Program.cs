using System;

namespace Calculadora
{
	public class Program
	{
		static void Main(string[] args)
		{
			// Llamar al método MostrarMenu desde la clase Menu
			Menu.MostrarMenu();

			// Leer la opción elegida por el usuario
			int opcion = Convert.ToInt32(Console.ReadLine());

			// Procesar la opción elegida
			Menu.ProcesarOpcion(opcion);
		}
	}
}
