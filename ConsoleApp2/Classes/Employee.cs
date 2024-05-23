public class Employee
{
    public int Id;
    public int ManagementLevel;
    public int Salary;

    public Employee(int id,int managementLevel, int salary)
    {
        Id = id;
        ManagementLevel = managementLevel;
        Salary = salary;
    }

    public  int getId()
    {
        return Id;
    }

    public int getManagementLevel() 
    {
        return ManagementLevel;
    }

    public int getSalary() 
    { 
        return Salary;
    }
    public void setId(int id)
    { 
        this .Id = id;
    }
    public void setManagementLevel(int ManagementLevel)
    {
        this.ManagementLevel = ManagementLevel;
    }

    public void setSalary(int salary)
    {
        this.Salary = salary;
    }
    public override string ToString()
    {
        return $"Management level: {ManagementLevel}\n" +
               $"Salary: {Salary}";
    }
}
