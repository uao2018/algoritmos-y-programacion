using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

class Funciones {
	//public static void leerDatos (string[] arrNom, int[] arrPun, int N) {
	

	//public static string crearReporte(string[] arrNom, int[] arrPunt, int N) {
	
	public static void ordenamientoBurbujaPorPuntajes(string[] arrNom, int[] arrPun, int N)	{
		// Variables temporales: 
		String tempAlfabetico;
		int tempNumerico;
		for (int i = 0; i < N - 1; i++)		{
			for (int j = 0; j < N - 1 - i; j++)			{
				if (arrPun[j] > arrPun[j + 1])				{
					// Intercambio: Ordena los estudiantes según la calificación --> 
					
					tempNumerico = arrPun[j];
					arrPun[j] = arrPun[j + 1];
					arrPun[j + 1] = tempNumerico;
					// Intercambio: Ordena los arrNom según la calificación --> 
					tempAlfabetico = arrNom[j];
					arrNom[j] = arrNom[j + 1];
					arrNom[j + 1] = tempAlfabetico;					
				}
			}   // if 
		}   // for j  
	}   // for i                     
} 

