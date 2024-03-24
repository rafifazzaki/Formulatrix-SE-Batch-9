public abstract class Component
{
    protected string name;
    public Component(string name){
        this.name = name;
    }

    public abstract void Add(Component c);
    public abstract void Remove(Component c);
    public abstract void Display(int depth);
}

public class Composite : Component
{
    List<Component> children = new List<Component>();

    public Composite(string name) : base(name){}

    public override void Add(Component c){
        children.Add(c);
    }

    public override void Remove(Component c)
    {
        children.Remove(c);
    }
    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + name);
        foreach (Component c in children)
        {
            c.Display(depth + 2);
        }
    }
}

public class Leaf : Component{
    public Leaf(string name) : base(name) {}

    public override void Add(Component c)
    {
        Console.WriteLine("Cannot add to a leaf");
    }

    public override void Remove(Component c)
    {
        Console.WriteLine("Cannot remove from a leaf");
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + name);
    }
}

