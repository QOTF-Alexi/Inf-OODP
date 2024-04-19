public class Robot
{
    private int _power;
    public int Power
    {
        get => _power; private set
        {
            if (value <= 0) _power = 0;
            else _power = value;
        } }

    public bool IsFused{ get; private set; }

    public Robot(int power)
    {
        Power = power;
        IsFused = false;
    }

    private Robot(int power, bool isFused)
    {
        IsFused = isFused;
        Power = power;
    }

    public int Attack()
    {
        int oldPow = Power;
        Power = oldPow / 2;
        return oldPow;
    }

    public static Robot operator +(Robot r1, Robot r2)
    {
        if (r1 == null && r2 == null)
        {
            return null;
        }
        else if (r1 == null || r2 == null)
        {
            return r2;
        }
        return new Robot(r1.Power + r2.Power, false);
    }

    public static Robot operator *(Robot r1, Robot r2)
    {
        if (r1 == null && r2 == null)
        {
            return null;
        }
        else if (r1 == null || r2 == null)
        {
            return r2;
        }
        return new Robot(r1.Power * r2.Power, true);
    }
}
