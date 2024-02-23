public delegate int MyDelegate(int a, int b);

class Program
{
    static void Main()
    {
        int a = 6;
        int b = 2;

        Calculator calc = new();

        MyDelegate myDelegate = calc.Add;
        myDelegate += calc.Mul;
        myDelegate += calc.Sub;

        Delegate[] delegates = myDelegate.GetInvocationList();
        int[] result = new int[delegates.Length];
        int index = 0;
        foreach(MyDelegate i in delegates) 
		{
			result[index] = i.Invoke(a, b);
			index++;
		}
        foreach (var i in result)
        {
            Console.WriteLine(i);
        }

        MyDelegate finalDelegate;
        finalDelegate = (MyDelegate)delegates[0];
        for (int i = 1; i < delegates.Length; i++)
        {
            finalDelegate += (MyDelegate)delegates[i];
        }
        int result2 = finalDelegate.Invoke(100, 5);
        Console.WriteLine(result2);
    }
}

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Sub(int a, int b)
    {
        return a + b;
    }

    public int Mul(int a, int b)
    {
        return a * b;
    }
    public int Div(int a, int b)
    {
        return a / b;
    }
}