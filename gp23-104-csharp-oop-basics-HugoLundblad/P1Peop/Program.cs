// See https://aka.ms/new-console-template for more information

Person[] person()
{
    return new Person[3];
}

for (int i = 0; i < person().Length; i++)
{
    Console.WriteLine(person);
}

public class Person {
    
}