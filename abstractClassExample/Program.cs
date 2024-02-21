class Program{
    static void Main(){
        MonopolyGameController monopoly = new(20);

        monopoly.AddCard(new FreeParkingCard(1, "free parking", "yellow"));
        monopoly.AddCard(new JailCard(2, "free parking", "red"));

        Console.WriteLine(MonopolyGameController.variableA);
    }
}

abstract class Card{
    private int _id;
    private string _name;
    private string _colour;

    public Card(int id, string name,string colour){
        _id = id;
        _name = name;
        _colour = colour;
    }

    public abstract void StartEffect(); //abstract itu inheritance tapi maksa buat semua childnya buat nerapin ini (tapi dia sendiri ngga ngasih contoh)
}

class FreeParkingCard : Card{
    public FreeParkingCard(int id,string name, string colour) : base(id, name, colour){

    }
    public override void StartEffect()
    {
        Console.WriteLine("Free Parking Card");
    }
}


class JailCard : Card{
    public JailCard(int id,string name, string colour) : base(id, name, colour){

    }
    public override void StartEffect()
    {
        Console.WriteLine("Jail Card");
    }
}

class FreeJailCard : Card{


    public FreeJailCard(int id,string name, string colour) : base(id, name, colour){

    }
    public override void StartEffect()
    {
        Console.WriteLine("Jail Card");
    }
}

class MonopolyGameController{
    private Card[] cards;

    private int count = 0;

    public static int variableA;

    public MonopolyGameController(int card){
        cards = new Card[card];
        variableA = 1;
    }

    public bool AddCard(Card card){
        if(count == cards.Length-1)
        cards[count] = card;
        count++;
        return true;
    }
}