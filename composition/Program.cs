// See https://aka.ms/new-console-template for more information

// composition: each attribute has it's own class
class Program{
    static void Main(){
        Engine engine = new Engine(3,"triple", "oil");
        Tire tire = new Tire(50, "tubeless");
        Motorcycle beatPop = new Motorcycle(engine, "beatPop", "honda", tire);

        Console.WriteLine(beatPop);
    }
}