using System;

// Repository Interface
public interface ICustomerRepository
{
    string FindCustomerById(int id);
}

// Concrete Repository
public class CustomerRepositoryImpl : ICustomerRepository
{
    public string FindCustomerById(int id)
    {
        return $"Customer Found with ID: {id}";
    }
}

// Service Class
public class CustomerService
{
    private readonly ICustomerRepository repository;

    // Constructor Injection
    public CustomerService(ICustomerRepository repository)
    {
        this.repository = repository;
    }

    public void GetCustomer(int id)
    {
        Console.WriteLine(repository.FindCustomerById(id));
    }
}

class Program
{
    static void Main()
    {
        ICustomerRepository repository =
            new CustomerRepositoryImpl();

        CustomerService service =
            new CustomerService(repository);

        service.GetCustomer(101);
    }
}
