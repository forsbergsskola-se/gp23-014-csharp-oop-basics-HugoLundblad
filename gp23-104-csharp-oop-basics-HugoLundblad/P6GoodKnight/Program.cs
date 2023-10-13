// See https://aka.ms/new-console-template for more information

Knight attacker = new Knight();
Knight defender = new Knight();

defender.Shield = new Shield();
attacker.Attack(defender);
attacker.Sword = new Sword();
Console.WriteLine("Equipping Sword...");
attacker.Attack(defender);
attacker.Attack(defender);

