class Program{
    static void Main(){
        Human human1 = new(200);
        Human human2 = new(55000);
        Human human3 = new(100);

        Console.WriteLine(Human.count);
        Console.WriteLine(human1.getBalance());
        Console.WriteLine(human2.getBalance());
        Console.WriteLine(human3.getBalance());
    }
}

// static jadi milik class
// method static tidak bisa ngambil yg bukan static, soalnya itu punya instance bukan miliknya class
class Human{
    public static int count;
    private int _balance;
    public Human(int money){
        count++;

        _balance = money;
    }

    public int getBalance(){
        return _balance;
    }
}