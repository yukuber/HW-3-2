using System;
static void Main()
{ 
    Parent[] array = new Parent[3];

    dim_one();

    dim_two();

    dim_three();

    array[0] = array1;
    array[1] = array2;
    array[2] = array3;

    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"Массив {array[i].GetType()}:");
        arr[i].Print();
        Console.WriteLine();
        Console.WriteLine($"Среднее значение массива {array[i]}: {array[i].Average()}");
        Console.WriteLine();
    }

}
static void dim_one()
{
    Console.WriteLine("Введите длину одномерного массива:");
    int a1 = int.Parse(Console.ReadLine());

    one_dim array1 = new(a1);

    array1.average();
    array1.pop100();
}
static void dim_two()
{
    Console.WriteLine("Введите высоту массива");
    int high_d2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите длину массивов");
    int len_d2 = int.Parse(Console.ReadLine());

    two_dim array2 = new(high_d2, len_d2);

    array2.average_d2();
    array2.obr_chet();
}
static void dim_three()
{
    Console.WriteLine("Введите высоту массива");
    int high_d3 = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите длинe одномерных массивов");
    int len_d3 = int.Parse(Console.ReadLine());

    three_dim array3 = new(high_d3);

    array3.average_three_dim();
    array3.average_each_three_dim();
    array3.muliply_three_dim();
}