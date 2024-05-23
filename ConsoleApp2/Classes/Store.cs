public class Store
{
    public int id;
    public int numberOfEmployees;
    public int incomeBalance;
    public int numberOfCustomers;
    public int advertisingBudget;
    public int numberOfProducts;
    public List<Employee> employeeArr;
    public List<Product> productArr;

    public Store(int id, int numberOfEmployees, int incomeBalance, int numberOfCustomers, int advertisingBudget, int numberOfProducts, List<Employee> employees, List<Product> products)
    {
        this.id = id;
        this.numberOfEmployees = numberOfEmployees;
        this.incomeBalance = incomeBalance;
        this.numberOfCustomers = numberOfCustomers;
        this.advertisingBudget = advertisingBudget;
        this.numberOfProducts = numberOfProducts;
        this.employeeArr = employees;
        this.productArr = products;
    }

    public int GetNumberOfEmployees()
    {
        return numberOfEmployees;
    }

    public int GetIncomeBalance()
    {
        return incomeBalance;
    }

    public int GetNumberOfCustomers()
    {
        return numberOfCustomers;
    }

    public int GetAdvertisingBudget()
    {
        return advertisingBudget;
    }

    public int GetNumberOfProducts()
    {
        return numberOfProducts;
    }

    public List<Employee> GetEmployees()
    {
        return employeeArr;
    }

    public List<Product> GetProducts()
    {
        return productArr;
    }

    // Setter methods for properties
    public void SetNumberOfEmployees(int value)
    {
        numberOfEmployees = value;
    }

    public void SetIncomeBalance(int value)
    {
        incomeBalance = value;
    }

    public void SetNumberOfCustomers(int value)
    {
        numberOfCustomers = value;
    }

    public void SetAdvertisingBudget(int value)
    {
        advertisingBudget = value;
    }

    public void SetNumberOfProducts(int value)
    {
        numberOfProducts = value;
    }

    public void SetEmployees(List<Employee> value)
    {
        employeeArr = value;
    }

    public void SetProducts(List<Product> value)
    {
        productArr = value;
    }

    public void AddEmployee(int managementLevel, int salary)
    {
        var newEmployee = new Employee(numberOfEmployees + 1, managementLevel, salary);
        employeeArr.Add(newEmployee);
    }

    public void RemoveEmployee(int id)
    {
        var employee = employeeArr.FirstOrDefault(e => e.Id == id);
        if (employee != null)
        {
            employeeArr.Remove(employee);
        }
    }
}

