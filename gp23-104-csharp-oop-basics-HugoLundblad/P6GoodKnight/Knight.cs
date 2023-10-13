
public class Knight
{
    public Sword Sword;
    public Shield Shield;

    public void GetHit(Sword sword)
    {
        if (Shield == null)
        {
            Console.WriteLine("The Knight has no Shield and is wounded.");
        }
        else
        {
            if (sword == null)
            {
                Console.WriteLine("Knights Shield fends off the strike.");
            }

            else
            {
                Shield = null;
                Console.WriteLine("Shield was pierced by the Sword.");
            }
        }
    }
    public void Attack(Knight target)
    {
        
        if (Sword == null)
        {
            Console.WriteLine("Knight attacks Knight with Bare Hands.");
        }
        else
        {
            Console.WriteLine("Knight attacks Knight with a Sword.");
        }
        target.GetHit(Sword);
    }
}