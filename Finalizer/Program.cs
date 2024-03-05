using System.Diagnostics;
// GC = Garbage Collector
class Program{
    static void Main(){
        int iteration = 1000;
        Stopwatch stopwatch = new();
        stopwatch.Start();
        for(int i = 0; i < iteration; i++) {
            InstanceCreator();
        }
        stopwatch.Stop();

        // maksa buat manggil GC
        // GC.Collect(0); //klo ngga salah bisa kyk gini
        GC.Collect(); //jangan make ini: bakal ngebersihin dan ngefreeze programnya sebentar
        GC.Collect();
        GC.WaitForPendingFinalizers(); //nunggu finalizernya dijalanin dulu baru lanjut lagi

        Console.WriteLine("Time Elapsed: ");
        Console.WriteLine(stopwatch.ElapsedMilliseconds);


        // GC ada multithread khusus, dan pas Finalizer jg ada thread sendiri lagi
    }
    static void InstanceCreator() {
        Human human = new Human();
    }
}

class Human{
    // jangan membuat Destructor walaupun kosongan seperti ini, karena tetap akan dipanggil:
    // ~Human(){ }
    public Human() { //Constructor
        Console.WriteLine("Human created");
        Console.WriteLine(GC.GetGeneration(this));
    }

    // Destructor akan dipanggil pas GC bersih-bersih, jadi kita tidak tau kapan bakal di jalankan
    // saat GC membersihkan memory dan ketemu dengan deconstructor ini, maka dia akan memindahkannya ke gen selanjutnya
    // dan baru akan dijalankan saat gen selanjutnya
    ~Human() { //Destructor
        Console.WriteLine("Human destroyed");
        Console.WriteLine(GC.GetGeneration(this));
    }
}