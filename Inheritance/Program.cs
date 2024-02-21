using Animals;

class Program{
    static void Main(){
        Cat cat = new("orange", "male");
        cat.name = "cinnamon";

        cat.Meow();

        Animal animal = cat; //bisa, karena informasi cat(child) lebih lengkap dari pada Animal(parent)
        // Cat cat = new Animal() tidak bisa (belum dicoba)
    }
}