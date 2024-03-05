
using System.Diagnostics;

class Program{
    static void Main(){
        string a = "a";
        int length = 1_000_000;
        Stopwatch sw = new();

        sw.Start();
        for (int i = 0; i < length; i++)
        {
            a += "b";
            a += "c";
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);
    }
}