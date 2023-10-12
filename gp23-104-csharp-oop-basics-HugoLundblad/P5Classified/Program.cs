// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");


public class Life
{
    public bool Alive = true;
}
public class Plant : Life{
    
}
public class Animal : Life{
    
}
public class Food : HeldItem {
    
}
public class Fruit : Food {
    public int VitaminValue;
}
public class HeldItem {
    public bool Holdable = true;
}
public class Weapon : HeldItem {
    
}
public class Bread : Food {

}
public class Banana : Fruit {
    
}
public class Apple : Fruit {
    
}
public class Pear : Fruit {
    
}
public class Sword : Weapon {
    
}
public class Axe : Weapon {
    
}
public class Pencil : HeldItem {
    
}
public class Shield : Weapon {
    
}
public class Spear : Weapon {
    
}
public class Tree : Plant {
    
}
public class Gorilla : Animal {
    
}
public class Chimpanzee : Animal {
    
}
public class Sparrow : Animal {
    
}
public class Pigeon : Animal {
    
}
public class Hawk : Animal {
    
}