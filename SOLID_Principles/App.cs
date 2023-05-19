
//this class is used to perform the "Single Responsibility Principle" means Coupling the reader class with writer class 
public class App
{
    private readonly IMessageReader _messageReader;
    private readonly IMessageWriter _messageWriter;

    public App(IMessageReader messageReader, IMessageWriter messageWriter)
    {
        _messageReader = messageReader;
        _messageWriter = messageWriter;
    }

    public void Run()
    {
        _messageWriter.WriteMessage(_messageReader.ReadMessage());  
    }
}