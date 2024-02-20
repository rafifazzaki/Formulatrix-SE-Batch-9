using System.Diagnostics;
using System.Text;

class Program{
    static void Main(){
        Stopwatch stopwatch = new();
        string a = "";
        string b = a;
        StringBuilder stringBuilders = new();

        stopwatch.Start();
        for (int i = 0; i < 10000; i++)
        {
            b += "a";
            b += "b";
            b.Replace("a","c");
        }
        stopwatch.Stop();
        Console.WriteLine("string: " + stopwatch.ElapsedMilliseconds);

        stopwatch.Restart();
        for (int i = 0; i < 10000; i++)
        {
            stringBuilders.Append("a");
            stringBuilders.Append("b");
            stringBuilders.Replace("a","c");
        }
        stopwatch.Stop();
        Console.WriteLine("stringBuilder: " + stopwatch.ElapsedMilliseconds);

    }
}