class Program{
    static object obj = new();
    static int Counter = 0;
    static async Task Main(){
        // method deadlock tunggu"an jadi programnya ngga bisa selesai
        // DeadLock();

        DeadLockSolution();

        // RaceCondition sama" make variable yang sama (outputnya bingung karena bisa jadi salah satu duluan atau kebalikannya)
        // RaceCondition()
        // solusinya pake lock dan semaphore (di project yg berbeda)
    }


    static async Task DeadLock(){
        Console.WriteLine("Program started");
        Task? task1 = null;
        Task? task2 = null;
        task2 = Task.Run(async () =>
        {
            Console.WriteLine("Task2 started");
            Console.WriteLine("Task2 completed");
            await task1;
        });
        
        task1 = Task.Run(async () =>
        {
            Console.WriteLine("Task1 started");
            await task2;
            Console.WriteLine("Task1 completed");
        });

        await Task.WhenAll(task1, task2);
        Console.WriteLine("Program finished");
    }
    
    static async Task DeadLockSolution(){
        Console.WriteLine("Program started");
        Task? task1 = null;
        Task? task2 = null;
        task2 = Task.Run(async () =>
        {
            Console.WriteLine("Task2 started");
            Console.WriteLine("Task2 completed");
            
        });
        await task2;
        task1 = Task.Run(async () =>
        {
            await task2;
            Console.WriteLine("Task1 started");
            
            Console.WriteLine("Task1 completed");
        });

        await Task.WhenAll(task1, task2);
        Console.WriteLine("Program finished");
    }

    static async Task RaceCondition(){
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