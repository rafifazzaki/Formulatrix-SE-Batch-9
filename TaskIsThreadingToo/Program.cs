class Program{
    static void Main(){
        Task task = new(Print);
        task.Start();
        try
        {
            Task.Run(() => ExceptionMaker());
        }
        catch (AggregateException e) //aggregate exception, kena exception dilempar lagi keluar
        {
            Console.WriteLine(e);
        }
        Task task2 = new Task(Iteration);
        task2.Start();
        

        
        Task<int> task3 = new Task<int>(ReturnSeven);
        task3.Start();
        

        Task<int> task4 = new Task<int>(() => MultiplyFive(5));
        task4.Start();
        
        // wait and waitAll is Thread blocking use When instead
        task.Wait();
        Task.WaitAll(); 

        Console.WriteLine(task3.Result);
        Console.WriteLine(task4.Result);
        Console.WriteLine(task2.IsCompleted);
        Console.WriteLine(task2.IsCanceled);
        Console.WriteLine(task2.IsFaulted);
        Console.WriteLine("Program Ended");
    }

    static async void DatabaseConnect(){
        Task<int> task = new Task<int>(() => MultiplyFive(5));
        await task;
    }

    static void Print(){
        Console.WriteLine("Hello World");
    }

    static void Iteration(){
        for (int i = 0; i < 100; i++)
        {
            Console.Write("+");
            Thread.Sleep(10);
        }
    }

    static int MultiplyFive(int number){
        return number * 5;
    }

    static int ReturnSeven(){
        return 7;
    }

    static void ExceptionMaker(){
        throw new FormatException("Exception thrown from ExceptionMaker"); 
    }
}