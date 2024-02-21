class Program{
    static void Main(){
        // nyimpen di stack
        int a = 3;
        // object nyimpennya di heap
        object b = a; //boxing

        int result = (int) b; //unboxing
    }

// kurang efisien karena if else bakal make cpu banyak banget, kalau mau nanti pakai generics
    static object Add(object obj1, object obj2){
        if(obj1 is int number1 && obj2 is int number2){
            return number1+number2;
        }

        if(obj1 is string && obj2 is string){
            return (string)obj1 + (string)obj2; 
        }

        return null;
    }
}

// untuk biar bisa ganti-ganti/ dinamis, tipe datanya bisa pakai object (contoh yg static object Add diatas)
//  atau kayak dibawah ini, polymorpyshm
// masalahnya klo pake object, (bakal pake if else) boros cpu karena if elsenya
// kalau pake banyak" yg float Add di kelas calculator dibawah ini sebenernya makan memory ram lebih banyak
class calculator{
    public float Add(float a, float b){
        return a+b;
    }
    public float Add(float a, int b){
        return a+b;
    }
    public float Add(int a, float b){
        return a+b;
    }
}