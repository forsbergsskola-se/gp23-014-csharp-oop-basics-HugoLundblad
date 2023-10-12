// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Knight attacker = new Knight();
Knight defender = new Knight();

defender.Shield = new Shield();
attacker.Attack(defender);
attacker.Sword = new Sword();
attacker.Attack(defender);
attacker.Attack(defender);

public class Wheel {}
public class Engine {}
public class Player {}
public class Car {
    public Wheel[] Wheels;
    public Engine Engine;
    public Player Driver;
}