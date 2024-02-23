class Program{
    static void Main(){
        string input = Console.ReadLine();
        int inputInt = 12; //valuenya ngga masuk karena out

        if(input is null){ //is = comparing type
            return;
        }
        
        try{
            
            TryIntegerAndDouble(in input, out inputInt, out double inputDouble); //out bisa di declare langsung
            MultiplyFive(ref inputInt);

            if(inputInt != 0){
                Console.WriteLine("input adalah integer " + inputInt);
            }else if(inputDouble != 0){
                Console.WriteLine("input adalah double " + inputDouble);
            } else{
                Console.WriteLine("input adalah string " + input);
            }

        }catch(FormatException){
            //if FormatException happens
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
        

    }

    static bool TryIntegerAndDouble(in string a, out int inputInt, out double inputDouble){
        inputInt = 0;
        inputDouble = 0;
        if(int.TryParse(a, out int intNumber)){
            inputInt = intNumber;
            return true;
        }
        if(double.TryParse(a, out double doubleNumber)){
            inputDouble = doubleNumber;
        }

        return false;

    }

    static void MultiplyFive(ref int number){
        number = number*5;
    }
}