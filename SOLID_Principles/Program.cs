using Unity;
//Responsibility 1: Object Creation
//When we used new keyword to create object then it performs tight coupling and somehow it is not good approach for a software architecture
//IMessageReader messageReader = new MessageReader();
//IMessageWriter messageWriter = new SocialMessageWriter();

//We are using IOC (Inversion of Control Principle) to get rid of new keywords
//IOC container is used ot manage object creation and object lifetime
//Mapping of Interface with classes
IUnityContainer _container = new UnityContainer();
_container.RegisterType<IMessageReader, MessageReader>();
_container.RegisterType<IMessageWriter, SocialMessageWriter>();

//we are not going to pass any parameter to container, it automatically do this for us
var app = _container.Resolve<App>();
app.Run();


//new App(messageReader, messageWriter);


//After using app() class we restrict the program.cs class to perform only single responsibility and that is Object Creation

//Responsibility 2: Coupling the reader class with writer class 
//messageWriter.WriteMessage(messageReader.ReadMessage());



