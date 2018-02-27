using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecioGasolina {

    class ClaseGasolina  {
        static double calcularPrecioGasolina (int tipoGas, double cantidadGas)  {
            double precioGas;
            if (tipoGas == 1) 
                precioGas = 8800 * cantidadGas;
            else
                precioGas = 10300 * cantidadGas;

            return precioGas;
        }

        static void Main(string[] args)        {
            int tipoG=0, dist=0;
            double precioG, cantidadG;
            Console.WriteLine("Tipo Gasolina: (1/2)");
            tipoG = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Distancia (Km)");
            dist = Convert.ToInt32(Console.ReadLine());

            if (tipoG == 1)
                cantidadG = dist / 45.0;
            else
                cantidadG = dist / 60.0;

            precioG = calcularPrecioGasolina(tipoG, cantidadG);

            Console.WriteLine("T:{0}, D:{1}, C:{2} P:{3}", tipoG, dist, cantidadG, precioG);

            Console.ReadKey();

        }
    }
}
