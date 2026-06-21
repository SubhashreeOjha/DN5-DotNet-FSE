using System;

// Subject Interface
public interface IImage
{
    void Display();
}

// Real Subject
public class RealImage : IImage
{
    private string fileName;

    public RealImage(string fileName)
    {
        this.fileName = fileName;
        LoadFromDisk();
    }

    private void LoadFromDisk()
    {
        Console.WriteLine("Loading " + fileName);
    }

    public void Display()
    {
        Console.WriteLine("Displaying " + fileName);
    }
}

// Proxy
public class ProxyImage : IImage
{
    private RealImage realImage;
    private string fileName;

    public ProxyImage(string fileName)
    {
        this.fileName = fileName;
    }

    public void Display()
    {
        if (realImage == null)
        {
            realImage = new RealImage(fileName);
        }

        realImage.Display();
    }
}

class Program
{
    static void Main(string[] args)
    {
        IImage image = new ProxyImage("test.jpg");

        image.Display();
        Console.WriteLine();

        image.Display();
    }
}
