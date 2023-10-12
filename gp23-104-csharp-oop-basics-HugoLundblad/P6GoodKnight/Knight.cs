
public class Knight
{
    public Sword Sword;
    public Shield Shield;

    public void GetHit(Sword sword)
    {
        if (sword.IsEquipped)
        {
            Console.WriteLine("Hello, World!");
        }
        Console.WriteLine("Hello, World!");
    }
    public void Attack(Knight target)
    {
        
        if (target.Shield.IsEquipped)
        {
            
        }
        target.GetHit(Sword);
        }

    }
}