abstract class Parent
{
    protected static Random rnd = new Random();
    protected bool fill_rand = false;
    protected Parent(bool fill_rand = false)
    {
        this.fill_rand = fill_rand;
    }
    public abstract void Rand();

    public abstract void Manual();
    
    public abstract void Print();
    
    public abstract double Average();
}