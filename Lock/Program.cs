using System.Diagnostics.Metrics;

class Program{
    static object obj = new();
    static int Counter = 0;
    static async Task Main(){
        Console.WriteLine("Program started");
        Task task1 = Task.Run(async () => await Incrementer());
        Task task2 = Task.Run(async () => await Incrementer());
        await Task.WhenAll(task1, task2);
        Console.WriteLine("Program ended");
    }

    static async Task Incrementer(){
        for (int i = 0; i < 100; i++)
        {
            // ngelocknya (simpen data) pake object
            // ie. thread1 masuk, make variable Counter dulu. setelah selesai thread2 baru make variablenya
            lock(obj){
                Counter++;
                Console.WriteLine(Counter);
            }
            
        }
        await Task.Delay(50);
    }
}