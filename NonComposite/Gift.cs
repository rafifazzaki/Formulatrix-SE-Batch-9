public class Gift : Component{
    private int actualPrice;
    public Gift(string name, int price) : base(name) {
        actualPrice = price;
    }

    public int GetActualPrice(){
        return actualPrice;
    }

    public override void Add(Component c)
    {
        Console.WriteLine("Cannot add to a gift");
    }

    public override void Remove(Component c)
    {
        Console.WriteLine("Cannot remove from a gift");
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + name);
    }
}

