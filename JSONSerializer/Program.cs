using System.Text.Json;
class Card {
    public string Name {get; set;}
    public string Effect {get; set;}

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
        string json = JsonSerializer.Serialize<List<Card>>(cards);
        using(StreamWriter sw = new("JSON.json")){
            sw.Write(json);
        }
    }

    static void DeserializeTestCards(){
        string result;
        using(StreamReader sr = new("JSON.json")){
            result = sr.ReadToEnd();
        }
        List<Card> cards = JsonSerializer.Deserialize<List<Card>>(result);
        foreach (var item in cards)
        {
            Console.WriteLine(item.Name);
        }
    }
}