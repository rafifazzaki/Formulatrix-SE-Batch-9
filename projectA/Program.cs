// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

class Program {
    static void Main(){
        Car avanza = new Car();
        avanza.name = "avanza";
        avanza.brand = "toyota";
        avanza.type = "wagon";
        avanza.year = 2018;
        Console.WriteLine(avanza.brand);
        avanza.Drive();

        Car ignis = new Car();
        ignis.name = "ignis";
        ignis.type = "wagon";
        ignis.brand = "suzuki";
        ignis.year = 2024;
        Console.WriteLine(ignis.brand);
        ignis.Brake();
    }
}

class Car {
    public string name;
    public string brand;
    public string type;
    public string colour;
    public int year;
    public bool isStillOnProduction = true;

    public void Drive(){
        Console.WriteLine("drive");
    }

    public void Turn(){
        Console.WriteLine("Turn");
    }

    public void Brake(){
        Console.WriteLine("brake");
    }
}