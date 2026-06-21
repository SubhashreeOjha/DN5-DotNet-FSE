using System;
using System.Collections.Generic;

// Observer Interface
public interface IObserver
{
    void Update(string stockName, double price);
}

// Subject Interface
public interface IStock
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}

// Concrete Subject
public class StockMarket : IStock
{
    private List<IObserver> observers = new List<IObserver>();

    private string stockName;
    private double price;

    public StockMarket(string stockName)
    {
        this.stockName = stockName;
    }

    public void SetPrice(double price)
    {
        this.price = price;
        NotifyObservers();
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(stockName, price);
        }
    }
}

// Concrete Observer 1
public class MobileApp : IObserver
{
    private string user;

    public MobileApp(string user)
    {
        this.user = user;
    }

    public void Update(string stockName, double price)
    {
        Console.WriteLine(
            $"Mobile App ({user}) - {stockName} price updated to ₹{price}");
    }
}

// Concrete Observer 2
public class WebApp : IObserver
{
    private string user;

    public WebApp(string user)
    {
        this.user = user;
    }

    public void Update(string stockName, double price)
    {
        Console.WriteLine(
            $"Web App ({user}) - {stockName} price updated to ₹{price}");
    }
}

class Program
{
    static void Main()
    {
        StockMarket stock = new StockMarket("TCS");

        IObserver mobileUser = new MobileApp("Subhashree");
        IObserver webUser = new WebApp("Investor");

        stock.RegisterObserver(mobileUser);
        stock.RegisterObserver(webUser);

        stock.SetPrice(4200);
        stock.SetPrice(4350);
    }
}
