abstract class Parent
{
    protected static Random rnd = new Random();
    protected Parent(bool fill_rand = false)
    {
        this.fill_rand = fill_rand;
    }

    public virtual void ReCreate(bool fill_rand = false)
        {
            if (fill_rand)
            {
                Manual();
            }
            else
            {
                Rand();
            }
        }

    protected abstract void Rand();

    protected abstract void Manual();
    
    public abstract void Print();
    
    public abstract double Average();
}