
using System.Diagnostics;
using System.Text;

class Program{
    static void Main(){
        StringBuilder a = new();
        a.Append("a");
        int length = 1_000_000;
        Stopwatch sw = new();

        sw.Start();
        for (int i = 0; i < length; i++)
        {
            a.Append("b");
            a.Append("c");
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);
    }
}