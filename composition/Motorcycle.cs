namespace Vehicle;

class Motorcycle{

    Engine engine;
    public string type;

    public string brand;

    public string colour;

    Tire tire;

    public Motorcycle(Engine engine,string type, string brand, Tire tire){
        this.type = type;
        this.brand = brand;
    }
}