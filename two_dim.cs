using System;

class two_dim : Parent
{
    private int[,] array2;

    public two_dim(int high_d2, int len_d2, bool fill_rand = false) : base(fill_rand)
    {
        ReCreate(fill_rand);
        Print();
    }

    public override void ReCreate(bool fill_rand)
    {
        base.ReCreate();
    }
    protected override void Rand()
    {
        for (int i = 0; i < array2.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                array2[i, j] = rnd.Next(-100, 100);
            }
        }
    }
    protected override void Manual()
    {
        for (int i = 0; i < array2.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                array2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

    }

    public override double Average()
    {
        int sam = 0;
        foreach (int elem in array2)
        {
            sam += elem;
        }
        return sam/array2.Length;
    }

    public void obr_chet()
    {
        for (int i = 0; i < array2.GetLength(0); i++)
        {
            if ((i + 1) % 2 == 0)
            {
                for (int j = array2.GetLength(1) - 1; j >= 0; j--)
                {
                    if (j == 0)
                    {
                        Console.WriteLine($"{array2[i, j]}");
                    }
                    else
                    {
                        Console.Write($"{array2[i, j]}");
                    }
                }
            }
            else
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    if (j == -1)
                    {
                        Console.WriteLine($"{array2[i, j]}");
                    }
                    else
                    {
                        Console.Write($"{array2[i, j]}");
                    }
                }
            }
        }
    }

    public override void Print()
    {
        Print(array2);
    }
    private static void Print(int[,] array2)
    {
        for (int i = 0; i<array2.GetLength(0); i++)
        {
            for (int j = 0; j <array2.GetLength(1);j++)
            {
                if (array2[i,j] == int.MinValue)
                {
                    continue;
                }
                Console.Write($"{array2[i,j]} ");            
            }
            Console.WriteLine();            
        }
    }
}

   