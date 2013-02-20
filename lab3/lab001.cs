using System;

class Program
{

    static void Main()
    {

        int n, m, i, j, d;

        Console.Write("Задайте количество элементов в массиве А: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Задайте количество элементов в массиве В: ");
        m = Convert.ToInt32(Console.ReadLine());

        int[] a = new int[n];
        int[] b = new int[m];

        int t1 = Environment.TickCount;

        Random Rnd = new Random();
        int maxValue = 1000;

        for (i = 0; i < n; i++)
        {
            a[i] = Rnd.Next(0, maxValue);
        }

        for (i = 0; i < m; i++)
        {
            b[i] = Rnd.Next(0, maxValue);
        }

        Console.Write("\nМассив А: ");
        for (i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }

        Console.Write("\nМассив B: ");
        for (i = 0; i < m; i++)
        {
            Console.Write(b[i] + " ");
        }

        for (i = 0; i < n; i++)
        {
            for (j = n - 1; j > i; j--)
            {
                if (a[j - 1] > a[j])
                {
                    d = a[j - 1];
                    a[j - 1] = a[j];
                    a[j] = d;
                }
            }
        }

        for (i = 0; i < m; i++)
        {
            for (j = m - 1; j > i; j--)
            {
                if (b[j - 1] > b[j])
                {
                    d = b[j - 1];
                    b[j - 1] = b[j];
                    b[j] = d;
                }
            }
        }

        Console.Write("\nМассив А после сортировки: ");
        for (i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }

        Console.Write("\nМассив В после сортировки: ");
        for (i = 0; i < m; i++)
        {
            Console.Write(b[i] + " ");
        }

        int[] c = new int[n + m];
        int count = 0;

        for (i = 0; i < a.Length; i++)
        {
            for (j = 0; j < b.Length; j++)
            {
                if (a[i] == b[j])
                {
                    c[count] = a[i];
                    count++;
                }
            }
        }

        if (count == 0)
        {
            Console.Write("\nСовпадений не найдено!");
        }
        else
        {
            Console.Write("\nМассив С: ");
            for (i = 0; i < count; i++)
            {
                Console.Write(c[i] + " ");
            }
        }

        int t2 = Environment.TickCount;

        Console.Write("\nПродолжительность работы программы: " + (t2 - t1) / 1000.0);
        Console.ReadKey(true);
    }
}
