using System.Collections;
using System.Security.Cryptography;
public delegate void PlatformToSendDelegate();
class Program{
    static void Main(){
        int[] integerNumbers = new int[10];
        int[] integerNumbers2 = {1, 2, 3};
        int[] integerNumbers3 = [0, 5, 7]; //dotnet 8

        ArrayList arrayList = new ArrayList();
        arrayList.Add(23);
        arrayList.Add(true);
        arrayList.Add("23");
        arrayList.Add(true);

        List<int> lists = new();
        lists.Add(2);
        lists.Add(45);
        lists.Add(12);
        Console.WriteLine(lists[0]);

        HashSet<int> myHs = new();
        myHs.Add(1);
        myHs.Add(2);
        myHs.Add(3);
        myHs.Add(4);

        myHs.Add(2); //ngga masuk

        HashSet<int> myHs2 = new();
        myHs2.Add(3);
        myHs2.Add(4);
        myHs2.Add(5);
        myHs2.Add(6);


        Console.WriteLine(myHs.Union(myHs2)); //semua masuk,nilai sama diabaikan

        
        // Console.WriteLine(myHs.Intersect(myHs2));
        // Console.WriteLine(myHs.Except(myHs2));

        LinkedList<string> kereta = new();

        kereta.AddFirst("gerbong awal");
        kereta.AddFirst("gerbong 1");
        kereta.AddFirst("gerbong 2");
        kereta.AddLast("gerbong akhir");
        kereta.AddLast("gerbong 1");
        kereta.AddLast("gerbong 1");

        // ready for testing this?
        // Console.WriteLine(kereta);

        Dictionary<int, string> dictionary = new();

        dictionary.Add(23, "twenty three");
        dictionary.Add(34, "thirdty four");

        // KeyValuePair => key = value
        // Dictionary => List<KeyValuePair<T, T2>>

        foreach(KeyValuePair<int, string> i in dictionary){
            Console.WriteLine(i.Key);
            Console.WriteLine(i.Value);
        }

        // LIFO
        Stack<int> stack = new();
        stack.Push(34);
        stack.Push(21);
        stack.Pop();
        stack.Peek();

        Queue<int> queue = new();
        queue.Enqueue(34);
        queue.Enqueue(87);
        queue.Enqueue(56);
        queue.Dequeue();
        queue.Peek();

        // penggunaan bisa untuk kartu uno, turn-based, atau lainnya
        // selain itu bisa juga delegate queue

        Queue<PlatformToSendDelegate> antrianDelegates = new();
    }
}