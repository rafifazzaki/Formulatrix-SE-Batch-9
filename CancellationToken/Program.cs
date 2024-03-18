class Program{
    static async Task Main(){
        CancellationTokenSource cts = new();
        CancellationToken token = cts.Token;

        Task task = Task.Run(() => Loading(token));
        Task task2 = Task.Run(() => WaitUserInput(cts));

        // try
        // {
        //     task.Wait();
        // }
        // catch (System.Exception)
        // {
        //     Console.WriteLine("handled");
        // }     

        await Task.WhenAny(task, task2);
    }

    static async Task Loading(CancellationToken token){
        int iteration = 100;
        for (int i = 1; i <= iteration; i++)
        {
            Console.WriteLine(i + "%");
            await Task.Delay(1000, token); //send token immediately, will throw exception
            // if(token.IsCancellationRequested){
            //     Console.WriteLine("Canceled");
            //     return;
            // }
        }
        Console.WriteLine("Job Completed");
    }

    static async Task WaitUserInput(CancellationTokenSource cts){
        if(Console.ReadKey().KeyChar == ' '){
            Console.WriteLine("pressed");
            cts.Cancel();
        }
    }
}