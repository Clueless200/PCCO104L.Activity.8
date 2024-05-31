using System;

// Abstract class defining a basic entity
public abstract class BaseEntity
{
    // Properties
    public string Name { get; set; }
    protected int ID { get; set; }

    // Constructor
    public BaseEntity(string name, int id)
    {
        Name = name;
        ID = id;
    }

    // Method
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, ID: {ID}");
    }
}

public class Employee : BaseEntity
{
    // Additional properties
    public string Department { get; set; }

    // Constructor
    public Employee(string name, int id, string department) : base(name, id)
    {
        Department = department;
    }

    // Method overriding
    public override void DisplayInfo()
    {
        Console.WriteLine($"Employee Name: {Name}, ID: {ID}, Department: {Department}");
    }
}

public class Manager : Employee
{
    public int TeamSize { get; set; }

    // Constructor
    public Manager(string name, int id, string department, int teamSize) : base(name, id, department)
    {
        TeamSize = teamSize;
    }

    // Method overriding
    public override void DisplayInfo()
    {
        Console.WriteLine($"Manager Name: {Name}, ID: {ID}, Department: {Department}, Team Size: {TeamSize}");
    }
}

public interface IExecutable
{
    void Execute();
}

public class Task : IExecutable
{
    // Properties
    public string Description { get; set; }

    // Constructor
    public Task(string description)
    {
        Description = description;
    }

    // Method from interface
    public void Execute()
    {
        Console.WriteLine($"Task '{Description}' is being executed.");
    }
}

public class Customer : BaseEntity
{
    // Additional properties
    public string Email { get; set; }

    // Constructor
    public Customer(string name, int id, string email) : base(name, id)
    {
        Email = email;
    }

    // Method overriding
    public override void DisplayInfo()
    {
        Console.WriteLine($"Customer Name: {Name}, ID: {ID}, Email: {Email}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating objects
        Employee employee = new Employee("Sample", 1, "IT");
        Manager manager = new Manager("Christian", 20, "Management", 10);
        Task task = new Task("Implementation");
        Customer customer = new Customer("Bob", 301, "ceu@example.com");

        // Displaying information
        employee.DisplayInfo();
        manager.DisplayInfo();
        task.Execute();
        customer.DisplayInfo();
    }
}
