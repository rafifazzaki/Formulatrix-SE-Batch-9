#define WINDOWS
// untuk manggil yg mau di kompilasi saja pakai define disini,
// atau <DefineConstants> di csproj, atau pas di command:
// dotnet build -c "WINDOWS"
// pas ngebuild dengan yg diatas kita bakalan ngebuild aplikasinya dengan nama tersebut,
// instead of "DEBUG"
// kalau kita "dotnet build" atau "dotnet run" otomatis bakal ngeset #define DEBUG,
//  jadi bisa dipake jg
class Program
{
    static void Main()
    {
        #if WINDOWS
            Console.WriteLine("message fo Windows");
        #elif LINUX
            Console.WriteLine("message fo Linux");
        #endif
    }
}