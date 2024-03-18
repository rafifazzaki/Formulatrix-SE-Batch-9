using System.Data.Common;
using System.Diagnostics;

class Program
{
    static async Task Main() //Task karena Main Threadnya juga masuknya kealam Task Pool
    {
        Stopwatch sw = new();
        Database db = new();

        sw.Start();
        /*
        #region 1 thread vs 1 task

        
        Thread th = new Thread(() => db.EmptyLooper());

        th.Start();
        th.Join();
        
        sw.Stop();
        Console.WriteLine("1 Thread: " + sw.ElapsedTicks);


        sw.Reset();
        sw.Start();

        Task task = new Task(() => db.EmptyLooper());
        
        task.Start();
        task.Wait();
        
        sw.Stop();
        Console.WriteLine("1 Task: " + sw.ElapsedTicks);
        #endregion
        */
        
        sw.Reset();
        sw.Start();
        db.StartManyThread(10);
        
        sw.Stop();
        Console.WriteLine("Many Thread: " + sw.ElapsedTicks);

        sw.Reset();
        sw.Start();

        db.StartManyTask(10);
        
        sw.Stop();

        Console.WriteLine("Many Task: " + sw.ElapsedTicks);

        sw.Reset();
        sw.Start();

        await db.StartAsyncAwait(10);

        sw.Stop();
        Console.WriteLine("Many Async Await: " + sw.ElapsedTicks);


        db.Matryoshka();
    }
}

class Database()
{
    // string text = "a";
    // public void StringLooper()
    // {
    //     for (int i = 0; i < 10; i++)
    //     {
    //         text += "b";
    //         text += "c";
    //     }
    // }

    public void EmptyLooper(){
        int iteration = 10;
        for (int i = 0; i < iteration; i++)
        {
            
        }
    }
    public void StartManyThread(int number)
    {
        Thread[] threads = new Thread[number];
        for (int i = 0; i < threads.Length; i++)
        {
            threads[i] = new Thread(() => EmptyLooper());
            threads[i].Start();
            threads[i].Join();
        }
    }

    public void StartManyTask(int number) {
        Task[] allTasks = new Task[number];
        for(int i = 0; i < allTasks.Length; i++) {
            allTasks[i] = new Task(() => EmptyLooper());
            allTasks[i].Start();
        }
        Task.WaitAll(allTasks);
    }

    // change to task from void
    public async Task StartAsyncAwait(int number){
        Task[] allTasks = new Task[100];
        for(int i = 0; i < allTasks.Length; i++) {
            allTasks[i] = new Task(() => EmptyLooper());
            allTasks[i].Start();
        }
        await Task.WhenAll(allTasks);
    }

    public void Matryoshka(){
        Console.WriteLine("Matryoshka");
        SmallMatryoshka();
    }

    public async void SmallMatryoshka(){
        Console.WriteLine("small");
        await SmallerThanSmallMatryoshka();
    }

    public async Task SmallerThanSmallMatryoshka(){
        Console.WriteLine("smaller than small Matryoshka");
        SmallestMatryoshka();
    }

    public void SmallestMatryoshka(){
        Console.WriteLine("smallest");
    }

}