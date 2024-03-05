/*Capturar N valores de tipo entero para almacenarlos en un arreglo y enviarlos a un método (procedimiento) para ordenarlos 
en forma ascendente mediante algún algoritmo de ordenamiento de datos. Al final, imprimir el arreglo ordenado desde 
el método principal Main()*/
namespace p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            Random x =new Random();
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i]=x.Next(0,30);    
            }
            numeros=ordenar(numeros);
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i]+" ");
            }
        }

        static int[] ordenar(int[] numeros)
        {
            int aux = 0;
            for (int i = 0; i < numeros.Length-1; i++)
            {
                for (int j = 0; j < numeros.Length-1-i; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        aux = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = aux;
                    }
                }
            }
            return numeros;
        }  
    }
}
