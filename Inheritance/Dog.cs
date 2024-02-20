namespace Animals;

public class Dog : Animal
{
    public string name;
    
    public Dog(string colour, string gender, bool isHealthy) : base(colour, gender, isHealthy){

    }

    public void Bark(){
        Console.WriteLine("woof woof");
    }
}
