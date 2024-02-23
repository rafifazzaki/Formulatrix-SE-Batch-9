class Program(){
    static void Main(){
        // value type
        int a = 0;
        valueTypeTest(a); //isinya a++
        Console.WriteLine(a); //nilai yg dipake yg 0 soalnya yg di tambah di valueTypeTest(a) itu beda address

        // reference type
        Human human = new(20);
        ReferenceTypeTest(human); //karena reference type yg dipake addressnya, jadi dia masih "ingat"
        Console.WriteLine(human.balance); 

        RefExample(ref a); //ref disini berarti int a yg di pass addressnya
        OutExample(out a); //out ngambil addressnya si a, tapi nilainya hilang dan harus diisi nilainya pas didalam fungsi
        InExample(in a); //ngambil address si a dan value, dan value tidak bisa diubah. fungsi? literally for optimization
    }

    
    static void valueTypeTest(int a){
        a++;
    }

    static void ReferenceTypeTest(Human a){
        a.balance++;
    }


    static void RefExample(ref int a){
        a++; 
    }

    static void OutExample(out int a){
        a = 0; //wajib isi nilai
    }

    static void InExample(in int a){
        int b = a + 1;
    }
}

class Human{
    public int balance;

    public Human(int balance){
        this.balance = balance;
    }
}