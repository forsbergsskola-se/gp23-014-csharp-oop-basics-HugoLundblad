// See https://aka.ms/new-console-template for more information


Person[] people = new Person[3];

for (int i = 0; i < people.Length; i++)
{
    people[i] = new Person();
}

for (int i = 0; i < people.Length; i++)
{
    Console.WriteLine(people[i]);
}

public class Person {
    
}