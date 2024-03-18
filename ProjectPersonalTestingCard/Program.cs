class Program{
    static void Main(){
        Player p1 = new();
        CardNumber cn1 = new();
        // Dictionary<Player, CardNumber> player = new();
        LinkedList<KeyValuePair<Player, CardNumber>> player = new();
        player.AddFirst(new KeyValuePair<Player, CardNumber>(p1, cn1));

        // foreach(var a in player){

        // }

        CardNumber card = new();


    }

    
}

public abstract class Game{
    public abstract void CardEffect();
}

public abstract class Card : Game{
    int a;

    public void getCard(int a){
        
    }    
    // public abstract void CardEffect();
}

public class Player{
    
}

public class CardNumber : Card
{
    // public CardNumber();
    public override void CardEffect()
    {
        
    }
}

public interface ICardEffect{
    void changeCard(Card card);
}