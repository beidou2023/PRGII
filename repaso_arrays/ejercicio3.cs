namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] temperaturas = [21,23,24,22,25,20,29,28,31,33,32,27,23];

            Console.WriteLine($"Promedio de temperatura del dia: {promedio(temperaturas)}");
            Console.WriteLine($"Numero de celda con la temperatura mas fria: {nceldamin(temperaturas)}");
            Console.WriteLine($"Numero de celda con la temperatura mas caliente: {nceldamax(temperaturas)}");
            Console.WriteLine($"Valor de la temperatura mas fria: {temparaturamin(temperaturas)}");
            Console.WriteLine($"Valor de la temperatura mas caliente: {temperaturamax(temperaturas)}");
        }
        static int promedio(int[]temperaturas)
        {
            int promedio= 0;
            foreach (var t in temperaturas)
            {
                promedio+=t;
            }
            promedio/= temperaturas.Length;
            return promedio;
        }
        static int nceldamin(int[] temperaturas)
        {
            int index= -1;
            int min = 9999;
            for (int i = 0; i < temperaturas.Length; i++)
            {
                if (temperaturas[i] <= min)
                { 
                    min= temperaturas[i];
                    index=i;
                }
            }
            return index;
        }
        static int nceldamax(int[] temperaturas)
        {
            int index = -1;
            int max = 0;
            for (int i = 0; i < temperaturas.Length; i++)
            {
                if (temperaturas[i]>= max)
                {
                    max= temperaturas[i];
                    index = i;
                }
            }
            return index;
        }
        static int temparaturamin(int[] temperaturas)
        {
            int min = 9999;
            for (int i = 0; i < temperaturas.Length; i++)
            {
                if (temperaturas[i] <= min)
                {
                    min = temperaturas[i];
                }
            }
            return min;
        }
        static int temperaturamax(int[] temperaturas)
        {
            int max = 0;
            for (int i = 0; i < temperaturas.Length; i++)
            {
                if (temperaturas[i] >= max)
                {
                    max = temperaturas[i];
                }
            }
            return max;
        }
    }
}
