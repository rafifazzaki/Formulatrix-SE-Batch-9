namespace PresentationComposite;

public class MiniFigurineCollectible : Component
{
    private int actualPrice;
    public List<string> MiniFigurineCollection {get; private set;}
    public MiniFigurineCollectible(string name, int price) : base(name) {
        actualPrice = price;
    }

    public int GetActualPrice(){
        return actualPrice;
    }

    public void AddMiniFigurineCollection(string miniFigurineCollection){
        MiniFigurineCollection.Add(miniFigurineCollection);
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
