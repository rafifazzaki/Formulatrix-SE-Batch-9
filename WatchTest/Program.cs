class Program
{
    static async void Main()
    {
        while (true)
        {
            Print();
            // await Task.Delay(1000);
            // Thread.Sleep(1000);
        }


    }

    static void Print()
    {
        Console.WriteLine("hello");
        Thread.Sleep(1000);
    }
}