// See https://aka.ms/new-console-template for more information

Player player1 = new Player();
Player player2 = new Player();

PvP(player1, player2);
PvP(player2, player1);
player1.Attack(player1);
Console.WriteLine("Player 1 attacks Player 1");
Console.WriteLine($"Player 1 damage: {player1.Damage}");
Console.WriteLine($"Player 2 damage: {player2.Damage}");
Player player3 = player1;
PvP(player2, player3);
Console.WriteLine($"Player 3 damage: {player3.Damage}");



void PvP(Player a, Player b)
{
    a.Attack(b);
    Console.WriteLine(a == player1 ? "Player 1 attacks Player 2" : "Player 2 attacks Player 1");
    Console.WriteLine($"Player 1 damage: {player1.Damage}");
    Console.WriteLine($"Player 2 damage: {player2.Damage}");
}
