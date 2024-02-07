public class Program
{
    public static void Main()
    {
        int attack = 50;
        double critChance = 0.33;
        int bossHP = 1000;

        Random critGenerator = new Random();
        while (bossHP > 0)
        {
            double critHit = critGenerator.NextDouble();
            int damage;
            if (critHit <= critChance) {
                damage = attack * 2;
            }
            else
            {
                damage = attack;
            }

            bossHP -= damage;
            Console.WriteLine("Boss HP: " + bossHP);
            Console.WriteLine("damage: " + damage);
            Console.WriteLine("");
        }

        Console.WriteLine("Boss defeated");
    }
}