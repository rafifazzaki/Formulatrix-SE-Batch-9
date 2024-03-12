using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Xml.Serialization;
[DataContract]
class Card { //must public
    [DataMember]
    private string Name;
    [DataMember]
    private string Effect; 

    public Card(string name, string effect){
        Name = name;
        Effect = effect;
    }

    public string GetName(){
        return Name;
    }
    public string GetEffect(){
        return Effect;
    }
}
class Program{
    static void Main(){
        SerializeTestCards();
        // DeserializeTestCards();
    }
    static void SerializeTestCards(){
        Card card1 = new Card("Wild Card", "Change Current Card Color");
        Card card2 = new Card("Reverse Card", "Reverse Current Game Turn");
        List<Card> cards = new List<Card> {card1, card2};
        DataContractJsonSerializer jsonSerializer = new(typeof(List<Card>));
        using(FileStream fs = new("JSONTest.json", FileMode.Create, FileAccess.Write)){
            jsonSerializer.WriteObject(fs, cards);
        }
    }

    static void DeserializeTestCards(){
        List<Card> cards;
        XmlSerializer serializer = new(typeof(List<Card>));
        using(StreamReader sr = new("fileXML.xml")){
            cards = (List<Card>) serializer.Deserialize(sr);
        }

        foreach(Card card in cards){
            // Console.WriteLine(card.Name);
            // Console.WriteLine(card.Effect);
        }
    }
}