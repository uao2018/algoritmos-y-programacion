using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArreglos2D{
    class Program {
        static void printMat(int[,] X) {
            int nFils = X.GetLength(0);
            int nCols = X.GetLength(1);
            for (int i = 0; i < nFils; i++) {
                for (int j = 0; j < nCols; j++)
                    Console.Write(X[i, j] + " ");
                Console.WriteLine();
            }
        }
        static void Main(string[] args){
            int[,] M = new int[5, 4];

            M[2, 3] = 8;

            printMat(M);
            Console.ReadKey();

        }
    }
}
