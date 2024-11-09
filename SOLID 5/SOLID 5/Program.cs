using SOLID_5;

class Program
{
    static void Main(string[] args)
    {
        Application application = new Application(new ConsoleLogger());
        application.Action();
        application.logger = new FileLogger();
        application.Action();
    }
}