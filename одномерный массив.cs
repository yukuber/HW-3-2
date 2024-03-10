using System;

<<<<<<< HEAD
class one_dim //класс одномерного массива
{
    private int[] array;
    private static Random rand = new Random();
    public one_dim (int len_one_dim, bool fill_rand)
=======
class one_dim : Parent //класс одномерного массива
{
    private int[] array;
    public one_dim (int len_one_dim, bool fill_rand = false) : base(fill_rand)
>>>>>>> 1d37bb1638ccbd503917df86fc5746cfc5f40fb0
    {
        ReCreate(len_one_dim, fill_rand);
    }
    
    
<<<<<<< HEAD
    private void one_dim_rand ()
=======
    protected override void Rand()
>>>>>>> 1d37bb1638ccbd503917df86fc5746cfc5f40fb0
    {
        Random rnd = new Random();
        for (int i = 0; i<array.Length;i++)
        {
            array[i] = rnd.Next(-100,100);
        }
    }
<<<<<<< HEAD
    private void one_dim_manual()
=======
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
>>>>>>> 1d37bb1638ccbd503917df86fc5746cfc5f40fb0
    {
        for (int i = 0; i<array.Length; i++)
            {
                Console.WriteLine($"значение {i}:");
                int x = int.Parse(Console.ReadLine());
                array[i] = x;
            }
    }
<<<<<<< HEAD
    public void Print()
    {
        Print(array);
    }
    public void average() //вычисление среднего арифметического 
=======
    public override void Print()
    {
        Print(array);
    }
    public override double Average() //вычисление среднего арифметического 
>>>>>>> 1d37bb1638ccbd503917df86fc5746cfc5f40fb0
    {
        double sam = 0;
        foreach(int elem in array)
        {
            sam+=elem;
        }
        Console.WriteLine("среднее арифметическое");
<<<<<<< HEAD
        Console.WriteLine(sam/array.Length);
    }
        
    public int[] pop100() //удаление всех чисел больше 100 по модулю
    {
        Console.WriteLine("укороченный");
        foreach(int elem in array)
        {
            kor_array[i] = Math.Abs(array[i]) < 100
                ? array[i]
                : int.MinValue;
            Print(kor_array)
        }
    }

    private static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == int.MinValue)
            {
                continue;
            }
            Console.Write($"{array[i]} ")
        }
        Console.WriteLine();            
    }
        
    public int[] non_repeat()
    {
        int[] unique = array.Distinct().ToArray();
        Print(unique);
    }
        
    
    public void ReCreate (int len_one_dim, bool fill_rand)
    {
        array = new int[len_one_dim];
        if (fill_rand)
        {
            one_dim_rand();
        }
        else
        {
            one_dim_manual();
        }
=======
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
>>>>>>> 1d37bb1638ccbd503917df86fc5746cfc5f40fb0
    }
}
