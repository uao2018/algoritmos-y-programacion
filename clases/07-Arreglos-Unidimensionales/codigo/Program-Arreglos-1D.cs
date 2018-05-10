using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArreglos1D{
    class Program    {
        static void imprimir (int[] X)        {
            int n = X.Length;
            for (int i = 0; i < n; i++)
                Console.Write(X[i] + " ");
            Console.WriteLine("");
        }
        // Retorna cuantas veces se repite "e" en "X"
        static int contar (int []X, int e) {
            int contador = 0;
            for (int i = 0; i < X.Length; i++)
                if (X[i] == e) contador++;
            return contador;
        }
        // Retorna true o false si el elemento "e" esta o no en "X", resp.
        static bool buscar(int[] X, int e) {
            for (int i = 0; i < X.Length; i++) 
                if (X[i] == e)     
                    return true;
            return false;
        }

        // Ordena el arreglo "X"
        static void ordenar (int []X)   {
            int n = X.Length;
            for (int i=0; i<n;i++) {
                for (int j=0; j < n-1; j++) {
                    if (X[j] > X[j+1]) {
                        int tmp = X[j];
                        X[j] = X[j + 1];
                        X[j + 1] = tmp;
                    }
                }
            }
        }
        // Retorna el numero que mas se repite
        static int mayorRepeticiones(int[] X)        {
            int mayorNumero = X[0];
            int mayorCuenta = contar(X, mayorNumero);

            for (int i=1; i<X.Length; i++)        {
                int sigNumero = X[i];
                int sigCuenta = contar(X, sigNumero);

                if (sigCuenta > mayorCuenta)
                    mayorNumero = sigNumero;
            }
            return mayorNumero;
        }

        // PRINCIPAL
        static void Main(string[] args)        {
            int[] A = { 9, 6, 5, 7, 3, 4, 2, 1, 8};
            int[] B = {2, 3, 4, 9, 7, 1, 4, 9, 1, 1, 9 };


            imprimir(A);
            int c2 = contar(A, 2);
            Console.WriteLine(c2);

            bool esta = buscar(A, 8);
            Console.WriteLine(esta);

            imprimir(A);
            ordenar(A);
            imprimir(A);

            int mayorRepite = mayorRepeticiones(B);
            imprimir(B);
            Console.Write("El mayor repeticiones es: ");
            Console.WriteLine(mayorRepite);

            Console.ReadKey();

        }
    }
}
