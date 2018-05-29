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


namespace GUIPractica3 {
    public partial class frPrincipal : Form
    {
        int N;
        string[] arrNombres;
        double[] arrNotas;

        public frPrincipal()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btIniciar_Click(object sender, EventArgs e)
        {
            string strN = Interaction.InputBox("Ingrese Numero Estudiantes:", "Iniciar", "1", 100, 0);
            N = Convert.ToInt32(strN);
            arrNombres = new string[N];
            arrNotas = new double[N];        
        }

        private void btLeer_Click(object sender, EventArgs e)
        {
            llenarDatos(arrNombres, arrNotas);
        }

        private void btReporte_Click(object sender, EventArgs e)
        {
            string cadenaReporte = reporteDatos (arrNombres, arrNotas);
            MessageBox.Show(cadenaReporte);
        }
        private void btProcesar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calculando.....de OK");
            redondear(arrNotas);
            ordenarDatos(arrNombres, arrNotas);
        }
            // Retorna una cadena con todos los nombres y las notas de los arreglos
        static string reporteDatos(string[] arrNombres, double[] arrNotas)
        {
            string cadenaReporte = "----REPORTE-----\n";
            cadenaReporte = cadenaReporte + "Nombre\t\tNota\n";
            int n = arrNombres.Length;
            for (int i = 0; i < n; i++)
            {
                string nombre = arrNombres[i];
                double nota = arrNotas[i];
                string cad = nombre + "\t\t" + nota + "\n";
                cadenaReporte = cadenaReporte + cad;
            }
            return cadenaReporte;
        }
        // Llena los arreglos con nombres y notas
        static void llenarDatos(string[] arrNombres, double[] arrNotas)
        {
            int n = arrNombres.Length;
            for (int i = 0; i < n; i++)
            {
                string nombre = Interaction.InputBox("Ingrese Nombre Estudiante:", "", "Pedrito", 100, 0);
                arrNombres[i] = nombre;

                string strNota = Interaction.InputBox("Ingrese Nota:", "", "0.0", 100, 0);
                double nota = Convert.ToDouble(strNota);
                arrNotas[i] = nota;
            }
        }
        // Ordena alfabeticamente el primer arreglo y hace los cambios
        // respectivos en el segundo
        static void ordenarDatos(string[] arrNombres, double[] arrNotas)
        {
            for (int a = 1; a < arrNombres.Length; a++)
                for (int b = arrNombres.Length - 1; b >= a; b--)
                {
                    if (arrNombres[b - 1].CompareTo(arrNombres[b]) > 0)
                    {
                        string tmpNombre = arrNombres[b - 1];
                        arrNombres[b - 1] = arrNombres[b];
                        arrNombres[b] = tmpNombre;

                        double tmpNota = arrNotas[b - 1];
                        arrNotas[b - 1] = arrNotas[b];
                        arrNotas[b] = tmpNota;
                    }
                }
        }

        static void redondear (double []X)
        {
            for (int i=0; i < X.Length; i++)
            {
                double notaActual = X[i];
                double notaNueva = notaActual;
                if (notaActual > 2.5 && notaActual < 3.0)
                    notaNueva = 3.0;
                if (notaActual > 4.5 && notaActual < 5.0)
                    notaNueva = 5.0;

                X[i] = notaNueva;
            }
        }
    }
}

