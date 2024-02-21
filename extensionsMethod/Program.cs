class Program{
    //string[] args itu buat nanti pas dari terminal contoh "dotnet run production" bakal masuk sebagai parameter argument (bisa di if)
    static void Main(String[] args){ 
        int a = 3;
        "test".Cetak();
        3.Cetak();
        3.Bandingkan(4).Cetak();

    }
}

static class NamaApapun{
    public static void Cetak(this object a){
        Console.WriteLine(a);
    }

    public static int Bandingkan(this int x, int y){
        if(x>y){
            return 1;
        }
        if(x<y){
            return -1;
        }
        return 0;
    }
}