class Program
{
    static void Main()
    {
        ReadText("test.txt");
    }

    static void ReadText(string path)
    {
        using FileStream fs = File.Open(path, FileMode.Open);
        StreamReader reader = new StreamReader(fs);
        string? line;
        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }

    }

    // using "using()" is simplifies version of using "finally{ file.dispose(); }"
    // you can see the finally version on OldReadText
    static void NewReadText(string path)
    {
        using (FileStream fs = File.Open(path, FileMode.Open))
        {
            StreamReader reader = new StreamReader(fs);
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }

    static void OldReadText(string path)
    {
        FileStream fs = File.Open(path, FileMode.Open);
        StreamReader reader = new StreamReader(fs);
        try
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        finally
        {
            reader.Dispose();
            fs.Dispose();
        }
    }
}