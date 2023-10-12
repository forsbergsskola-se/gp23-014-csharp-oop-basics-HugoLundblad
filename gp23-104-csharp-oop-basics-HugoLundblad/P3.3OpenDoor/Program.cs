// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

public class House
{
    public bool IsDoorOpen;

    public void OpenDoor()
    {
        this.IsDoorOpen = true;
    }
    
    public void CloseDoor()
    {
        this.IsDoorOpen = false;
    }
}