class Program
{
    static void Main()
    {
        Human human = new();
        human.Number = 12;
        Console.WriteLine(human.Number);

        human.Balance = 2;
        Console.WriteLine(human.Balance);

        human.SetDress("shirt");
        Console.WriteLine(human.Dress);
    }
}

class Human
{
    public int Number { get; internal set; } = 100; //properties (PascalCase), [private set;] so that it can't be set from outside
    internal int _balance;
    public int Balance
    {
        get
        {
            return _balance;
        }
        internal set //acn still use private, etc
        {
            _balance = value; //SetBalance(int value)
        }
    }

    public string Dress { get; set; } = "";

    public void SetDress(string dress)
    {
        Dress = dress;
    }

    public string GetDress()
    {
        return Dress;
    }
    
}

