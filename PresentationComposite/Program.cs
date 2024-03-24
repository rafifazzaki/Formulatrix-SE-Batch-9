using PresentationComposite;

class Program{
    static void Main(){
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Kinderjoy root = new Kinderjoy("Open Kinderjoy™");
        root.Add(new Gift("A toy car", 1));
        root.Add(new Gift("A pendant", 2));
        

        Kinderjoy kinderjoy2 = new Kinderjoy("Kinderjoy2™");
        kinderjoy2.Add(new Gift("A Lego-like set", 3));
        kinderjoy2.Add(new Gift("A magic trick tool", 2));

        Kinderjoy kinderjoy3 = new Kinderjoy("Kinderjoy3™");
        kinderjoy3.Add(new MiniFigurineCollectible("A small figurine heroes", 3));
        kinderjoy3.Add(new MiniFigurineCollectible("A small figurine heroine", 2));

        root.Add(kinderjoy2);
        root.Add(kinderjoy3);
        root.Add(new Gift("Charlie's Golden Ticket", 1));

        root.Display(1);
        Console.ReadLine();
    }
}