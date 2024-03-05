using System;
abstract class Parent
{
    protected static Random rnd = new Random();
    protected bool fill_rand = false;
    protected Parent(bool fill_rand = false)
    {
        this.fill_rand = fill_rand;
    }
    protected virtual void ReCreate()
    {
        
    }
    private abstract void Rand();

    private abstract void Manual();

    public virtual void Print()
    {
        foreach (int i in array)
        {
            Console.Write(i + ", ");
        }
    }

    public abstract double Average();

}