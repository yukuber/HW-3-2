using System;
class three_dim : Parent
{
    private int[][] array3;

    public three_dim(int high_three_dim, bool fill_rand = false) : base(fill_rand)
    {
        ReCreate(fill_rand);
    }

    public override void ReCreate(bool fill_rand)
    {
        base.ReCreate();
    }
    
    protected override void Rand()
    {
        for (int i = 0; i < array3.Length; i++)
        {
            for (int j = 0; j < rnd.Next(1, 10); j++)
            {
                array3[i][j] = rnd.Next(-100, 100);
            }
        }
    }

    protected override void Manual()
    {
        for (int i = 0; i < array3.Length; i++)
        {
            Console.WriteLine($"Введите длину подмассива {i}");
            int len_each_three_dim = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < len_each_three_dim; j++)
            {
                Console.Write($"Элемент [{i}],[{j}]: ");
                array3[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    public override double Average()
    {
        int sam = 0;
        for (int i = 0; i < array3.Length; i++)
        {
            for (int j = 0; j < array3[i].Length; j++)
            {
                sam += array3[i][j];
            }
        }
        return sam/array3.Length;
    }

    public void average_each_three_dim()
    {
        for (int i = 0; i < array3.Length; i++)
        {
            int sum = 0;
            for (int j = 0; j < array3[i].Length; j++)
            {
                sum += j;
                Console.WriteLine($"среднее значение в подмассиве {i} = {sum / array3[i].Length}");
            }
        }
    }

    public void muliply_three_dim()
    {
        for (int i = 0; i < array3.Length; i++)
        {
            for (int j = 0; j < array3[i].Length; j++)
            {
                Console.WriteLine("");
                if (j % 2 == 0)
                {
                    Console.Write(i * j);
                }
                else
                {
                    Console.Write(array3[i][j]);
                }
            }
        }
    }

    public override void Print()
    {
        Print(array3);
    }

    private static void Print(int[][] array3)
    {
        for (int i = 0; i<array3.Length; i++)
        {
            for (int j = 0; j <array3[i].Length;j++)
            {
                if (array3[i][j] == int.MinValue)
                {
                    continue;
                }
                Console.Write($"{array3[i][j]} ");            
            }
            Console.WriteLine();            
        }
    }
}
