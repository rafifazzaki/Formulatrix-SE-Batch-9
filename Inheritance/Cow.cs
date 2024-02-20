namespace Animals;

class Cow : Animal
{
    public Cow() : base("cow", "female", true){

    }
    internal void Moo()
    {
        Console.WriteLine("Moo");
    }
}
