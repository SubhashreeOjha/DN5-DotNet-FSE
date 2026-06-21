using System;

class Order
{
    public int OrderId;
    public string CustomerName;
    public double TotalPrice;

    public Order(int id, string name, double price)
    {
        OrderId = id;
        CustomerName = name;
        TotalPrice = price;
    }
}

class Program
{
    static void BubbleSort(Order[] orders)
    {
        int n = orders.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (orders[j].TotalPrice > orders[j + 1].TotalPrice)
                {
                    Order temp = orders[j];
                    orders[j] = orders[j + 1];
                    orders[j + 1] = temp;
                }
            }
        }
    }

    static void QuickSort(Order[] orders, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(orders, low, high);

            QuickSort(orders, low, pi - 1);
            QuickSort(orders, pi + 1, high);
        }
    }

    static int Partition(Order[] orders, int low, int high)
    {
        double pivot = orders[high].TotalPrice;
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (orders[j].TotalPrice < pivot)
            {
                i++;

                Order temp = orders[i];
                orders[i] = orders[j];
                orders[j] = temp;
            }
        }

        Order temp1 = orders[i + 1];
        orders[i + 1] = orders[high];
        orders[high] = temp1;

        return i + 1;
    }

    static void Display(Order[] orders)
    {
        foreach (Order order in orders)
        {
            Console.WriteLine(
                $"{order.OrderId} {order.CustomerName} ₹{order.TotalPrice}");
        }
    }

    static void Main()
    {
        Order[] orders =
        {
            new Order(1,"Rahul",5000),
            new Order(2,"Priya",2500),
            new Order(3,"Amit",8000),
            new Order(4,"Sneha",3500)
        };

        Console.WriteLine("Bubble Sort:");

        BubbleSort(orders);

        Display(orders);

        Order[] orders2 =
        {
            new Order(1,"Rahul",5000),
            new Order(2,"Priya",2500),
            new Order(3,"Amit",8000),
            new Order(4,"Sneha",3500)
        };

        Console.WriteLine("\nQuick Sort:");

        QuickSort(orders2, 0, orders2.Length - 1);

        Display(orders2);
    }
}
