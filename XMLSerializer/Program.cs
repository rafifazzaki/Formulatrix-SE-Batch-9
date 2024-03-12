using System.Text.Json;
using System.Xml.Serialization;
public class Card { //must public
    public string Name {get; set;}
    public string Effect; // can serialize variable too

    public Card(){ //needed

    }

    public Card(string name, string effect){
        Name = name;
        Effect = effect;
    }
}
class Program{
    static void Main(){
        // SerializeTestCards();
        DeserializeTestCards();
    }
    static void SerializeTestCards(){
        Card card1 = new Card("Wild Card", "Change Current Card Color");
        Card card2 = new Card("Reverse Card", "Reverse Current Game Turn");
        List<Card> cards = new List<Card> {card1, card2};
        XmlSerializer serializer = new XmlSerializer(typeof(List<Card>));

        using(StreamWriter sw = new("fileXML.xml")){
            serializer.Serialize(sw, cards);
        }
    }

    static void DeserializeTestCards(){
        List<Card> cards;
        XmlSerializer serializer = new(typeof(List<Card>));
        using(StreamReader sr = new("fileXML.xml")){
            cards = (List<Card>) serializer.Deserialize(sr);
        }

        foreach(Card card in cards){
            Console.WriteLine(card.Name);
            Console.WriteLine(card.Effect);
        }
    }
}