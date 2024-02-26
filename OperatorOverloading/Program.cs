class Program{
    static void Main(){
        Motorcycle mt = new(1000);
        Motorcycle mt2 = new(2000);
        Motorcycle mt3 = mt + mt2;

        Console.WriteLine(mt3.price);
    }
}

class Motorcycle{
    public readonly int price;
    public Motorcycle(int price){
        this.price = price;
    }
    // Operator overloading:
    // yang bisa semua operator + - * / ++ -- == != %
    public static Motorcycle operator +(Motorcycle a, Motorcycle b){
        return new Motorcycle(a.price + b.price);
    }
}