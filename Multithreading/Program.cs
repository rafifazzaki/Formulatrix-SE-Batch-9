class Program
{
    static void Main()
    {
        Console.WriteLine("Program Start");
        int gasPedal = 10;
        int brakePedal = 3;
        int clutchPedal = 5;
        int acceleration;
        int deceleration;
        int clutch;
        Car car = new();
        car.StartEngine();

        // Thread is foreground by default (will still running after program ended)
        Thread thread1 = new(car.HandBrake);

        Thread thread2 = new(() => clutch = car.Clutch(clutchPedal));
        Thread thread3 = new(() => acceleration = car.Gas(gasPedal));
        Thread thread4 = new(() => car.Turn(Turn.Right));
        Thread thread5 = new(() => car.Turn(Turn.Right));
        Thread thread6 = new(() => car.Turn(Turn.Right));
        Thread thread7 = new(() => car.Turn(Turn.Left));
        Thread thread8 = new(() => car.Turn(Turn.Left));
        Thread thread9 = new(() => car.Turn(Turn.Left));
        Thread thread10 = new(() => deceleration = car.Brake(brakePedal));

        thread4.IsBackground = true;
        thread5.IsBackground = true;


        // sebenarnya walaupun hanya di start bakalan dijalankan random 
        // (disini ada yg isBackground ada yg ngga, ada yg join ada yg ngga)
        #region thread started
        thread1.Start();
        thread2.Start();
        thread3.Start();
        thread4.Start();
        thread5.Start();
        thread6.Start();
        thread7.Start();
        thread8.Start();
        thread9.Start();
        thread10.Start();
        #endregion

        thread1.Join();
        thread2.Join();
        thread3.Join();
        thread10.Join();


        // explanation on the method
        Thread otherThread = new(car.OtherWaysToDoParams);
        otherThread.Start("message in");

        Thread threadException = new(() => {
            try
            {
                deceleration = car.Brake(brakePedal);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        });

        // jangan pake 2 method ini:
        // thread1.Priority = ThreadPriority.Highest;
        // thread1.Abort();

        Console.WriteLine("Program Ended");
    }
}

class Car
{
    public void StartEngine()
    {
        Console.WriteLine($"Start Engine, {Thread.CurrentThread.ManagedThreadId}");
    }
    public void Turn(Turn turn)
    {
        Console.WriteLine($"{turn}, {Thread.CurrentThread.ManagedThreadId}");
    }

    public void HandBrake()
    {
        Console.WriteLine($"Handbreak goes brrr, {Thread.CurrentThread.ManagedThreadId}");
    }
    public int Gas(int gasPedal)
    {
        Console.WriteLine($"Gas Gas Gas, {Thread.CurrentThread.ManagedThreadId}");
        return gasPedal;
    }
    public int Brake(int brakePedal)
    {
        Console.WriteLine($"Brake, {Thread.CurrentThread.ManagedThreadId}");
        return brakePedal;
    }
    public int Clutch(int clutchPedal)
    {
        Console.WriteLine($"Clutch, {Thread.CurrentThread.ManagedThreadId}");
        return clutchPedal;
    }

    public void OtherWaysToDoParams(object message){
        // change the int, or string, or whatever into an object
        // Then at the thread.Start("message in") then pass the parameter from the Start method
        Console.WriteLine(message);
    }

}

enum Turn
{
    Right,
    Left
}