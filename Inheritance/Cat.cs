namespace Animals;

public class Cat : Animal
{
    public string name;
    

    public Cat(string colour, string gender) : base(colour, gender , true)
    {
        Console.WriteLine("child");
    }

    public void Meow(){
        Console.WriteLine("Meow meow");
    }
}
