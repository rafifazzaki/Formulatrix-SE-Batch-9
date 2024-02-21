class Program{
    static void Main(){
        Cat cat = new();
        double doubleNumber = 2.0;
        int intNumber = 3;

        int c = (int) doubleNumber; // int from double. Harus explisit downcasting
        double d = (double) intNumber; //double from int. Explisit upcasting, sudah implisit tidak perlu explisit
        
        float floatNumber = 4.3f;

        c = (int) floatNumber; //int from float.harus explisit downcasting
        floatNumber = intNumber;

        Console.WriteLine(doubleNumber);
        Console.WriteLine(intNumber);
        Console.WriteLine(floatNumber);
        Console.WriteLine(c);
        Console.WriteLine(d);
        

        Animal animal = cat;
        MakeSound(cat);
        MakeSound(animal);
        MakeSound(new Dog());
        MakeSound(new Animal());
        MakeSound(new Ant());

        Console.WriteLine(new Car(2000));

    }

    static void MakeSound(Animal animal){
        animal.Sound();
    }
}

class Car{
    public int price;

    public Car(int price){
        this.price = price;
    }

    // why override this? karena kalau langsung console writeline
    // nge toString class name 
    public override string ToString()
    {
        return price.ToString();
    }
}