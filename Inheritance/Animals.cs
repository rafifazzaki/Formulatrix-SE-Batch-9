namespace Animals;

public class Animal
{
    public string gender;
    public string colour;
    public bool isHealthy;

    public Animal(string colour, string gender, bool isHealthy){
        this.gender = gender;
        this.colour = colour;
        this.isHealthy = isHealthy;
        
        Console.WriteLine("Parent");
    }

    public void walk(){

    }

    public void Sleep(){

    }

    public void Eat(){
        
    }
}
