using System.Numerics;

class Program{
    static void Main(){
        var Calculator = new Calculator<int, int>();

        Console.WriteLine(Calculator.Add(2, 4));
        Console.WriteLine(Calculator.Multiply(2, 4));
        Console.WriteLine(Calculator.Substraction(2, 4));
        Console.WriteLine(Calculator.Division(2, 4));
    }
}

class Calculator{}

class TestGenerics<T> where T :INumber<T> {} //membatasi generics dengan interface Inumber
class TestTwoGenerics<T, T2> 
    where T : INumber<T> 
    where T2 : INumber<T2> {} //membatasi generics dengan 2 interface INumber

class Calculator<T, T2> : Calculator  //constraint T, T2 with INumber + child of Calculator
    where T : INumber<T> 
    where T2 : INumber<T2>
    {
    public T Add(T data1, T data2) {
		return data1 + data2;
	}
    public T Substraction(T data1, T data2) {
		return data1 - data2;
	}

    public T Multiply(T data1, T data2) {
		return data1 * data2;
	}

    public T Division(T data1, T data2) {
		return data1 / data2;
	}
    
}