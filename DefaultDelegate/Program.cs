class Program{
    static void Main(){
        Calculator calculator = new();
        //sama dengan public delegate void Action<T>(T parameter)
        Action<string, int> testAction = calculator.PrintNumberMessage;
        // bisa kyk gini:
        var testAction2 = calculator.PrintNumberMessage;

        //sama dengan public delegate T2 Func<T, T1, T2>(T data1, T1 data2)
        Func <int, int, int> testFunc = calculator.Add;
        
        testAction?.Invoke("test", 2);
        testFunc.Invoke(2,3);

        // lanjut:
        // kalau mau perhitungan simple tapi ngga mau bikin kelas baru:
        // anonymous method atau Lambda Expression

        Func<int, int, float> myFunc = (int a, int b) => (a+b); //return a+b
        myFunc += (int a, int b) => {
            if(b == 0){
                return -1;
            }
            return a/b;
        };

        Action<string> messageParameter = (string message) => Console.WriteLine(message);
        Action message = () => Console.WriteLine("Hi");
        
    }
}

class Calculator{
    public int Add(int a, int b){
        return a+b;
    }

    public int Mul(int a,int b){
        return a*b;
    }

    public void PrintNumberMessage(string message, int number){
        Console.WriteLine("message " + number);
    }
}

class Human{
    int _balance;
    // anonymous method/lambda function pada properties
    public int Balance => _balance * 1000;

}