namespace Animals;
// the child can be another child, then another child, but each child only has one parent

public class Animal
{
    protected string gender;
    protected string colour;
    protected bool isHealthy;

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
