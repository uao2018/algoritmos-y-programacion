using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

public partial class Form1 : Form
{
	public Form1() 	{
		InitializeComponent();
	}

	private void btSalir_Click(object sender, EventArgs e) 	{
		Close();
	}

	private void btIniciar_Click(object sender, EventArgs e) {
		principal();
	}

	public static void principal () {
		int N;
		string reporte;

		int[] arrPuntajes;
		string[] arrNombres;

		N = Convert.ToInt32(Interaction.InputBox("Cuantos Jugadores: "));
		arrNombres = new string[N];
		arrPuntajes = new int[N];

		Funciones.leerDatos (arrNombres, arrPuntajes, N);
		reporte = Funciones.crearReporte(arrNombres, arrPuntajes, N);
		MessageBox.Show ("Reporte sin ordenar: \n" + reporte);

		Funciones.ordenamientoBurbujaPorPuntajes(arrNombres, arrPuntajes, N); // solo llamarlo. Supone que ya existe
		reporte = Funciones.crearReporte(arrNombres, arrPuntajes, N);
		MessageBox.Show ("Reporte ordenado por puntaje: \n" + reporte);
	}
}
