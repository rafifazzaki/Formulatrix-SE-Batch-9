using System.Text;
using System.Text.Unicode;

class Program{
    static object obj = new();
    static async Task Main(){
        CreateTextFile("text/test.txt");
        CreateFileProtected("text/testProtected.txt");

        

        await WriteFileStream("text/testStreamWriter.txt");
        // await ReadFileStream("text/testStreamWriter.txt");
        
        // await ReadFileStream2("text/testStreamWriter.txt");
        await WriteDirectlyFromStream("text/directly");
    }

    static void CreateTextFile(string path){
        using(FileStream fs = new FileStream(@path, FileMode.Create, FileAccess.Write)){
            string text = "Hello World";
            byte[] mybytes = new byte[text.Length];
            mybytes = Encoding.UTF8.GetBytes(text);
            fs.Write(mybytes, 0, mybytes.Length);
        }
    }

    static void CreateFileProtected(string path){
        using(FileStream fs = new FileStream(@path, FileMode.Create, FileAccess.Write, FileShare.None)){
            string text = "Hello World";
            byte[] mybytes = new byte[text.Length];
            mybytes = Encoding.UTF8.GetBytes(text);
            fs.Write(mybytes, 0, mybytes.Length);
        }
    }

    static async Task ReadFileStream(string path){
        using(FileStream fs = new FileStream(@path, FileMode.Open, FileAccess.Read)){
            using(StreamReader sr = new StreamReader(fs)){
                string result = await sr.ReadToEndAsync();
                Console.WriteLine(result);
            }
        }
    }

    static async Task ReadFileStream2(string path){
        using(FileStream fs = new FileStream(@path, FileMode.Open, FileAccess.Read)){
            using(StreamReader sr = new StreamReader(fs)){
                string result = await sr.ReadLineAsync();
                Console.WriteLine(result);
            }
        }
    }
    
    static async Task WriteFileStream(string path){
        using(FileStream fs = new FileStream(@path, FileMode.Create, FileAccess.Write)){
            lock(obj){
                    using(StreamWriter sw = new StreamWriter(fs)){
                    sw.WriteAsync("test"); 
                    sw.WriteAsync("Hello, World!");
                    sw.WriteAsync("Hello, World!");
                }
            }
        }

        using(FileStream fs = new FileStream(@path, FileMode.OpenOrCreate, FileAccess.ReadWrite)){
            using(StreamWriter sw = new StreamWriter(fs)){
                    await sw.WriteAsync("test"); 
                    fs.Seek(-3, SeekOrigin.End);
                    await sw.WriteLineAsync();
                    await sw.WriteAsync("Hello, World!");
                    fs.Seek(-3, SeekOrigin.Current);
                    await sw.WriteLineAsync();
                    await sw.WriteAsync("Hello, World!");
            }
        }
    }
    static async void ReadFileStream3(string @path){
        string? result;
        using(StreamReader sr = new(path)){
            result = await sr.ReadLineAsync();
            result += await sr.ReadLineAsync();
        }
    }
    static async Task WriteDirectlyFromStream(string @path){
        using(StreamWriter sw = new StreamWriter(path)){
            await sw.WriteLineAsync("Directly From Stream");
        }
    }

}