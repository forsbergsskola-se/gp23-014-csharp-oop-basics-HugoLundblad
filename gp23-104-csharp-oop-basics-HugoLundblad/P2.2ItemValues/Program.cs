// See https://aka.ms/new-console-template for more information

Item[] items = new Item[3];

for (int i = 0; i < items.Length; i++)
{
    items[i] = new Item();
    items[i].goldValue += 100 + (100 * i);
}

for (int i = 0; i < items.Length; i++)
{
    Console.WriteLine(items[i].goldValue);
}

public class Item {
    public int goldValue;
}