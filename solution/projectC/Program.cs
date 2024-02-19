// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

class Program{
    static void Main(){
        Calculator calc = new Calculator();
        int result = calc.Addition(3,2); //camelcase
        Console.WriteLine($"Hasil Addition: {result}");
        Console.WriteLine(calc.Substraction(3,2));
        Console.WriteLine(calc.Multiplication(3,2));
        Console.WriteLine(calc.Division(3,2));
    }
}


class Calculator{ //PascalCase
    public int Addition(int number1, int number2){
        return number1+number2;
    }

    public int Substraction(int number1, int number2){
        return number1-number2;
    }

    public int Multiplication(int number1, int number2){
        return number1*number2;
    }

    public int Division(int number1, int number2){
        return number1/number2;
    }
}