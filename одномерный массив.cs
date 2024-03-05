using System;

class one_dim : Parent //класс одномерного массива
{
    private int[] array;
    public one_dim (int len_one_dim, bool fill_rand = false) : base(fill_rand)
    {
        ReCreate(len_one_dim, fill_rand);
    }
    
    
    protected override void Rand()
    {
        Random rnd = new Random();
        for (int i = 0; i<array.Length;i++)
        {
            array[i] = rnd.Next(-100,100);
        }
    }
    public void ReCreate (int len_one_dim, bool fill_rand)
    {
        array = new int[len_one_dim];
        if (fill_rand)
        {
            Rand();
        }
        else
        {
            Manual();
        }
    }
    protected override void Manual()
    {
        for (int i = 0; i<array.Length; i++)
            {
                Console.WriteLine($"значение {i}:");
                int x = int.Parse(Console.ReadLine());
                array[i] = x;
            }
    }
    public override void Print()
    {
        Print(array);
    }
    public override double Average() //вычисление среднего арифметического 
    {
        double sam = 0;
        foreach(int elem in array)
        {
            sam+=elem;
        }
        Console.WriteLine("среднее арифметическое");
        return sam/array.Length;
    }
        
    // public void pop100() //удаление всех чисел больше 100 по модулю
    // {
        
    //     Console.WriteLine("укороченный");
    //     foreach(int elem in array)
    //     {
    //         kor_array[i] = Math.Abs(array[i]) < 100
    //             ? array[i]
    //             : int.MinValue;
    //         Print(kor_array)
    //     }
    // }

    public void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == int.MinValue)
            {
                continue;
            }
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();            
    }
        
    public void non_repeat()
    {
        int[] unique = array.Distinct().ToArray();
        Print(unique);
    }
}
