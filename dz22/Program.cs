class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[5];

        Console.WriteLine("Enter the 5 numbers(a): ");
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("A: ");
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
        int sumA = 0;
        foreach (var item in a)
        {
            sumA += item;
        }
        int dobytokA = 1;
        foreach (var item in a)
        {
            dobytokA *= item;
        }
        Console.Write("Even num A: ");
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % 2 == 0)
            {
                Console.Write(a[i] + " ");
            }
        }
        int[,] b = new int[3, 4];
        Console.WriteLine("B: ");
        Random rnd = new Random();
        for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                b[i, j] = rnd.Next(1, 100);
            }
        }
        for (int i = 0; i <= b.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= b.GetUpperBound(1); j++)
            {
                Console.Write(b[i, j] + " ");
            }
            Console.WriteLine();
        }
        int maxB = b[0, 0];
        for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                if (b[i, j] > maxB)
                {
                    maxB = b[i, j];
                }
            }
        }
        int minB = b[0, 0];
        for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                if (b[i, j] < minB)
                {
                    minB = b[i, j];
                }
            }
        }
        int sumaB = 0;
        foreach (var item in b)
        {
            sumaB += item;
        }
        int dobytokB = 1;
        foreach (var item in b)
        {
            dobytokB *= item;
        }
        Console.Write("Not even num B: ");
        for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                if (b[i, j] % 2 != 0)
                {
                    Console.Write(b[i, j] + " ");
                }
            }
        }
        Console.WriteLine("\nDobytokB: " + dobytokB);
        Console.WriteLine("DobytokA: " + dobytokA);
        Console.WriteLine("Max element A: " + a.Max());
        Console.WriteLine("Min element A: " + a.Min());
        Console.WriteLine("Zagalna Sum A: " + sumA);
        Console.WriteLine("Max B: " + maxB);
        Console.WriteLine("Min B: " + minB);
        Console.WriteLine("Zagal B: " + sumaB);
    }
}
