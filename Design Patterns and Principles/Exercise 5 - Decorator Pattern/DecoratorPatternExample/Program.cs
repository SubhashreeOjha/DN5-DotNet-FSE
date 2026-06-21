using System;

// Component
public interface INotifier
{
    void Send();
}

// Concrete Component
public class EmailNotifier : INotifier
{
    public void Send()
    {
        Console.WriteLine("Sending Email Notification");
    }
}

// Base Decorator
public abstract class NotifierDecorator : INotifier
{
    protected INotifier notifier;

    public NotifierDecorator(INotifier notifier)
    {
        this.notifier = notifier;
    }

    public virtual void Send()
    {
        notifier.Send();
    }
}

// Concrete Decorator 1
public class SMSNotifierDecorator : NotifierDecorator
{
    public SMSNotifierDecorator(INotifier notifier) : base(notifier)
    {
    }

    public override void Send()
    {
        base.Send();
        Console.WriteLine("Sending SMS Notification");
    }
}

// Concrete Decorator 2
public class SlackNotifierDecorator : NotifierDecorator
{
    public SlackNotifierDecorator(INotifier notifier) : base(notifier)
    {
    }

    public override void Send()
    {
        base.Send();
        Console.WriteLine("Sending Slack Notification");
    }
}

class Program
{
    static void Main(string[] args)
    {
        INotifier notifier = new EmailNotifier();

        notifier = new SMSNotifierDecorator(notifier);
        notifier = new SlackNotifierDecorator(notifier);

        notifier.Send();
    }
}
