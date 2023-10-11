// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

while (true)
{
    Player p1 = new Player();
    Console.WriteLine($"Lvl: {p1.Level}, Exp: {p1.Experience}");
    p1.GrantExperience();
}

public class Player {
    public int Level;
    public int Experience;
    
    public void GrantExperience() {
        Experience += int.Parse(Console.ReadLine());
        
        // Level Up
        if(Experience >= 100)
        {
            Level += Experience / 100;
            Experience %= 100;
        }
        
        Console.WriteLine($"Lvl: {Level}, Exp: {Experience}");
    }
}