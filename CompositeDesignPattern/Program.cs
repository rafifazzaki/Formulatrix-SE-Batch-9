class Program{
    static void Main(){
        Composite root = new Composite("Open Sesame");
        root.Add(new Leaf("Leaf A"));
        root.Add(new Leaf("Leaf B"));

        Composite comp = new Composite("Composite X");
        comp.Add(new Leaf("Leaf A from X"));
        comp.Add(new Leaf("Leaf B from X"));

        root.Add(comp);
        root.Add(new Leaf("Leaf C"));

        root.Display(1);
        Console.ReadLine();
    }
}