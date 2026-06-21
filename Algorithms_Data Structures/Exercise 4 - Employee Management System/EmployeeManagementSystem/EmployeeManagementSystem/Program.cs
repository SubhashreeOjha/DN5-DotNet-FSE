using System;
using System.Collections.Generic;

class Employee
{
    public int EmployeeId;
    public string Name;
    public string Position;
    public double Salary;

    public Employee(int id, string name, string position, double salary)
    {
        EmployeeId = id;
        Name = name;
        Position = position;
        Salary = salary;
    }
}

class EmployeeManagement
{
    private List<Employee> employees = new List<Employee>();

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public Employee SearchEmployee(int id)
    {
        foreach (Employee employee in employees)
        {
            if (employee.EmployeeId == id)
            {
                return employee;
            }
        }
        return null;
    }

    public void DisplayEmployees()
    {
        foreach (Employee employee in employees)
        {
            Console.WriteLine(
                $"{employee.EmployeeId} {employee.Name} {employee.Position} ₹{employee.Salary}");
        }
    }
}

class Program
{
    static void Main()
    {
        EmployeeManagement manager = new EmployeeManagement();

        manager.AddEmployee(
            new Employee(101, "Rahul", "Manager", 60000));

        manager.AddEmployee(
            new Employee(102, "Priya", "Developer", 50000));

        manager.AddEmployee(
            new Employee(103, "Amit", "Tester", 45000));

        Console.WriteLine("Employee List:");

        manager.DisplayEmployees();

        Console.WriteLine("\nSearching Employee ID 102:");

        Employee emp = manager.SearchEmployee(102);

        if (emp != null)
        {
            Console.WriteLine(
                $"{emp.EmployeeId} {emp.Name} {emp.Position} ₹{emp.Salary}");
        }
        else
        {
            Console.WriteLine("Employee Not Found");
        }
    }
}
