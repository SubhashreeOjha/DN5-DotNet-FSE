using System;

// Strategy Interface
public interface IPaymentStrategy
{
    void Pay(double amount);
}

// Concrete Strategy 1
public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid ₹{amount} using Credit Card");
    }
}

// Concrete Strategy 2
public class PayPalPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid ₹{amount} using PayPal");
    }
}

// Context
public class PaymentContext
{
    private IPaymentStrategy paymentStrategy;

    public PaymentContext(IPaymentStrategy paymentStrategy)
    {
        this.paymentStrategy = paymentStrategy;
    }

    public void ExecutePayment(double amount)
    {
        paymentStrategy.Pay(amount);
    }
}

class Program
{
    static void Main()
    {
        PaymentContext payment;

        payment = new PaymentContext(new CreditCardPayment());
        payment.ExecutePayment(2500);

        payment = new PaymentContext(new PayPalPayment());
        payment.ExecutePayment(5000);
    }
}
