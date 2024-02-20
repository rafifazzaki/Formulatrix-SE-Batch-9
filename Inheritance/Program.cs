using Animals;

class Program{
    static void Main(){
        Cat cat = new("orange", "male");
        cat.name = "cinnamon";

        cat.Meow();
    }
}