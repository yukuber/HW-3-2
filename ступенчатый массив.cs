
using System;
public sealed class three_dim : Parent
{
    private int high_three_dim;

    private int[][] array3;
    private bool fill_rand {get; set;}
    public three_dim(int high_three_dim)
    {
        array3 = new int[high_three_dim][];

        if (fill_rand)
        {
            Rand(high_three_dim);
        }
        else
        {
            Manual(high_three_dim);
        }
    }
    private override void Rand(int high_three_dim)
    {       Random rnd = new Random();
            for (int i = 0; i < high_three_dim; i++)
            {
                for (int j = 0; j < rnd.Next(1, 10); j++)
                {
                    array3[i][j] = rnd.Next(-100,100);
                }
            }
        }
       private override void Manual(int high_three_dim)
        {
            for (int i = 0; i < high_three_dim ; i++)
            {
                Console.WriteLine($"Введите длину подмассива {i}");
                int len_each_three_dim = int.Parse(Console.ReadLine());
                for (int j = 0; j < len_each_three_dim ; j++)
                {
                    Console.Write($"Элемент [{i}],[{j}]: ");
                    array3[i][j] = int.Parse(Console.ReadLine());
                }    
            }
        }
    public override void Average()
    {
        int sum = 0;
        for (int i = 0; i < high_three_dim; i++)
        {
            for (int j = 0; j < array3[i].Length; j++)
            {
                sum += j;
            }
        }
        Console.WriteLine($"среднее значение в массиве {sum}");
    }
    public void average_each_three_dim()
    {
        for (int i = 0; i < high_three_dim; i++)
        {
            int sum = 0;
            for (int j = 0; j < array3[i].Length; j++)
            {
                sum += j;
                Console.WriteLine($"среднее значение в подмассиве {i} = {sum}");
            }
        }
    }
    public void muliply_three_dim()
    {
        for (int i = 0; i < high_three_dim; i++)
        {
            for (int j = 0; j < array3[i].Length; j++)
            {
                Console.WriteLine("");
                if (j%2==0)
                {
                   Console.Write(i*j);
                }
                else
                {
                    Console.Write(array3[i][j]);
                }
                
            }
        }
        
    }
}


