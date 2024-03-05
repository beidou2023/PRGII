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
