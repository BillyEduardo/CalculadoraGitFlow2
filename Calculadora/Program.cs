using System;

namespace Calculadora
{
	public class Program
	{
		static void Main(string[] args)
		{
			int opcion;

			// Usamos un bucle para mostrar el menú repetidamente hasta que el usuario elija salir
			do
			{
				// Llamar al método MostrarMenu desde la clase Menu
				Menu.MostrarMenu();

				
				bool opcionValida = int.TryParse(Console.ReadLine(), out opcion);

				
				if (opcionValida)
				{
					
					Menu.ProcesarOpcion(opcion);
				}
				else
				{
					Console.WriteLine("Por favor ingrese una opción válida.");
					opcion = 0; 
				}

				// Preguntar al usuario si desea realizar otra operación
				Console.WriteLine("¿Desea realizar otra operación? (si/no): ");
			}
			while (Console.ReadLine().ToLower() == "si"); 

			
			Console.WriteLine("¡Gracias por usar la calculadora!");
		}
	}
}
