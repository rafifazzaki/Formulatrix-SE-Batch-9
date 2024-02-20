namespace Animals;

public class Dog : Animal
{
    internal string name;
    
    public Dog(string colour, string gender, bool isHealthy) : base(colour, gender, isHealthy){

    }

    internal void Bark(){
        Console.WriteLine("woof woof");
    }
}
