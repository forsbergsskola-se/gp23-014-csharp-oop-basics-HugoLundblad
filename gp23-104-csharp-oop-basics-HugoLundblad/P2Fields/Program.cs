// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Player playerA = new Player();

playerA.Gold = 200;
playerA.Stone = 110;
playerA.Wood = 53;
playerA.Level = 12;
playerA.Experience = 123;
playerA.Subscribed = true;
playerA.PvPToggle = false;
playerA.PlayerName = "Marc";
playerA.PlayerMail = "marc@zaku.de";

Console.WriteLine($"Player A has {playerA.Gold} Gold, {playerA.Stone} Stone, {playerA.Wood} Wood. He is level {playerA.Level} and has {playerA.Experience} Experience.");
Console.WriteLine("He " + (playerA.Subscribed ? "has" : "does not have") + " an active VIP subscription and PVP is " + (playerA.PvPToggle ? "enabled." : "disabled."));
Console.WriteLine($"His display name is {playerA.PlayerName} and his e-mail address is {playerA.PlayerMail}.");

public class Player {
    public int Gold;
    public int Stone;
    public int Wood;
    public int Level;
    public int Experience;
    public bool Subscribed;
    public bool PvPToggle;
    public string PlayerName;
    public string PlayerMail;
}