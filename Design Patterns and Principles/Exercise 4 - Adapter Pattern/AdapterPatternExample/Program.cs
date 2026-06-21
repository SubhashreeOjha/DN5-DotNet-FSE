using System;
// Target Interface
interface IPaymentProcessor
{
    void ProcessPayment(double amount);
}
// Adaptee 1
class PayPalGateway
{
    public void MakePayment(double amount)
    {
        Console.WriteLine($"Paid ₹{amount} using PayPal.");
    }
}
// Adaptee 2
class StripeGateway
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid ₹{amount} using Stripe.");
    }
}
// Adapter for PayPal
class PayPalAdapter : IPaymentProcessor
{
    private PayPalGateway paypal;
    public PayPalAdapter(PayPalGateway paypal)
    {
        this.paypal = paypal;
    }
    public void ProcessPayment(double amount)
    {
        paypal.MakePayment(amount);
    }
}

// Adapter for Stripe
class StripeAdapter : IPaymentProcessor
{
    private StripeGateway stripe;

    public StripeAdapter(StripeGateway stripe)
    {
        this.stripe = stripe;
    }

    public void ProcessPayment(double amount)
    {
        stripe.Pay(amount);
    }
}
class Program
{
    static void Main()
    {
        IPaymentProcessor payment1 =
            new PayPalAdapter(new PayPalGateway());
        payment1.ProcessPayment(1000);
        IPaymentProcessor payment2 =
            new StripeAdapter(new StripeGateway());
        payment2.ProcessPayment(2000);
    }
}
