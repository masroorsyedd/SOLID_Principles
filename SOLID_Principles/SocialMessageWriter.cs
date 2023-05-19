public class SocialMessageWriter : IMessageWriter
{
    public SocialMessageWriter()
    {
    }

    public void WriteMessage(string message)
    {
        Console.WriteLine($"Social Media Message : {message}");
    }
}