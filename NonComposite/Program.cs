using PresentationComposite;

class Program{
    static void Main(){
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        List<object> a = new();
        a.Add(new Gift("A toy car", 1));
        a.Add(new Gift("A pendant", 2));
        a.Add(new MiniFigurineCollectible("A small figurine heroes", 3));
        a.Add(new Kinderjoy("Kinderjoy2™"));


        Gift b = (Gift)a[1];
        Console.WriteLine(b.GetActualPrice());
        
        Console.ReadLine();
    }
}