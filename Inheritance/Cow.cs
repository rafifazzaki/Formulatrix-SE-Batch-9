namespace Animals;

class Cow : Animal
{
    public Cow() : base("cow", "female", true){

    }
    public void Moo()
    {
        Console.WriteLine("Moo");
    }
}
