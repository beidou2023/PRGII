/*Capture los datos numéricos enteros de un arreglo de N posiciones, el cual puede contener valores positivos y negativos. 
Envíe estos datos a un método (procedimiento) que sustituya los números negativos por cero. 
Al final, imprima el arreglo modificado desde el método principal Main().*/
namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]numeros=new int[20];
            Random x=new Random();
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = x.Next(-20, 21);
            }
            numeros=convertir(numeros);
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i]+" ");
            }

        }

        static int[] convertir(int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    numeros[i] = 0;
                }
            }
            return numeros;
        }
    }
}
