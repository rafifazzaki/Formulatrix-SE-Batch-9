class Program{
    static void Main(){
        int result  = Calculator.Add(2,3,4,5,6);
        Console.WriteLine(result);
    }

    public static class Calculator{
        public static int Add(params int[] numbers){
            int result = 0;
            foreach(var i in numbers){
                result += i;
            }
            return result;
        }
    }
}
