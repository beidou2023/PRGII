/*Calcular el promedio y la desviación estándar de un conjunto de N números ingresados por teclado y almacenados 
en un arreglo unidimensional. La desviación estándar se calcula con la siguiente fórmula:
                σ = √((1/(n-1))Σ(xᵢ - μ)²)
Donde:
σ es la desviación estándar.
n es tamaño del arreglo
x es Arreglo de tamaño N
x_i Valor de la celda i del arreglo x
μ es promedio de los dataos almacenados en el arreglo x
N es el número total de datos.
*/
namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double promedi,desviacion;
            int[] numeros = new int[20];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese el numero "+(i+1)+":");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

            }
            promedi = promedio(numeros);
            desviacion = raiz(numeros, promedi);
            Console.WriteLine("El promedio de los numeros es de: " + promedi);
            Console.WriteLine("La desviacion estandar es de: " + desviacion);
        }
        static double promedio(int[] numeros)
        {
            double promedio = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                promedio += numeros[i];
            }
            promedio /= numeros.Length;
            return promedio;
        }

        static double raiz(int[] numeros, double promedio)
        {
            double raiz = 0;
            double sum = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                sum += Math.Pow((numeros[i] - promedio), 2);
            }
            raiz = Math.Pow(sum / (numeros.Length - 1), 1 / 2);
            return raiz;
        }
    }
}
