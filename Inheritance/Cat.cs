namespace Animals;

public class Cat : Animal
{
    internal string name;
    

    public Cat(string colour, string gender) : base(colour, gender , true)
    {
        Console.WriteLine("child");
    }

    internal void Meow(){
        Console.WriteLine("Meow meow");
    }
}
