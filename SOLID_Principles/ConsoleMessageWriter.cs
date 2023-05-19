public class ConsoleMessageWriter : IMessageWriter
{
    public ConsoleMessageWriter()
    {
    }

    public void WriteMessage(string message)
    {
        Console.WriteLine(message);
    }
}