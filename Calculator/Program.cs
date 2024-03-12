/// <summary>
/// Calculator to add two integer and substract two integer
/// </summary>
sealed class Calculator{ //sealed agar tidak bisa di di inherit
    /// <summary>
    /// method 2 parameter to number
    /// </summary>
    /// <param name="a">first integer</param>
    /// <param name="b">second integer</param>
    /// <returns>result of addition</returns>
    public int Add(int a, int b){
        return a + b;
    }
    public int Subtract(int a, int b){
        return a - b;
    }
}
class Program{
    static void Main(){
        Calculator calc = new();
        int integerResult = calc.Add(3, 4);
        Console.WriteLine(integerResult);
    }
}