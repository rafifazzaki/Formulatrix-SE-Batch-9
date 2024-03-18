using System.Diagnostics;

class Program
{
    static async void Main()
    {
        Debug.WriteLine("This line will only shown when you use debugger");

        ConsoleTraceListener consoleTraceListener = new();
        
        TextWriterTraceListener textWriterTraceListener = new("trace.log");
        
        Trace.Listeners.Add(consoleTraceListener);
        Trace.Listeners.Add(textWriterTraceListener);
        Trace.WriteLine("Starting the program");
    }

}