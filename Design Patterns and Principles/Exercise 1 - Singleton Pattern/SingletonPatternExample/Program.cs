using System;
class Logger
{
    private static Logger? instance;

    private Logger()
    {
    }

    public static Logger GetInstance()
    {
        if (instance == null)
        {
            instance = new Logger();
        }

        return instance;
    }

    public void Log(string message)
    {
        Console.WriteLine("LOG: " + message);
    }
}
class Program
{
    static void Main()
    {
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();

        logger1.Log("Application Started");

        Console.WriteLine(
            "Same Instance? " +
            (logger1 == logger2));
    }
}
