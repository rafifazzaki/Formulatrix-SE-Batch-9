//3 foo
// 5 bar
// User input => n
// n = 15
// 0, 1, 2, foo, 4, bar, foo, 7, 8, foo, bar, 11, foo, 13, 14, foobar

class Program{
    static void Main(){
        string input = Console.ReadLine();
        ChangeToFooAndBar.Run(input);

    }
}

class ChangeToFooAndBar{
    // private int[] number;
    public static void Run(string input){
        int.TryParse(input, out int a);
        Console.WriteLine("0");
        for(int i=1; i<a+1; i++){
            if(i%3 == 0 && i%5 == 0){
                Console.WriteLine("Foobar");
            }else if(i%3 == 0){
                Console.WriteLine("Foo");
            }else if(i%5 == 0){
                Console.WriteLine("bar");
            }else{
                Console.WriteLine(i);
            }
        }
    }
}