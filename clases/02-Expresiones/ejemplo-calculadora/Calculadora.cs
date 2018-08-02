using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
	class Program
	{
		static void Main(string[] args)
		{
			int opcion;
			double valor1, valor2, valor3, resultado;
			bool salir = false;

			while (salir == false) {
				Console.WriteLine ("Opciones");
				Console.WriteLine ("1. Suma");
				Console.WriteLine ("2. Coseno");
				Console.WriteLine ("0. Salir");

				opcion = Convert.ToInt16(Console.ReadLine());
				if (opcion == 0) {
					salir = true;
				} else {
					// Suma
					if (opcion == 1) { // Suma 
						Console.WriteLine("Ingrese Valor1:");
						valor1 = Convert.ToInt16(Console.ReadLine());
						Console.WriteLine("Ingrese Valor2:");
						valor2 = Convert.ToInt16(Console.ReadLine());
						resultado = valor1 + valor2;
						Console.WriteLine("El resultado fue: " + resultado);
					}
					// Coseno
					if (opcion == 2)
					{ // Suma 
						Console.WriteLine("Ingrese Valor1:");
						valor1 = Convert.ToDouble(Console.ReadLine());

						resultado = Math.Cos (valor);
						Console.WriteLine("El resultado fue: " + resultado);
					}

					// Raiz Quadrada

					// Potencia

					// Division



				} 
			}
		}
	}
}
