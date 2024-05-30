﻿using static System.Formats.Asn1.AsnWriter;

public abstract class State
{
    public int numberOfEmployees;
    public int incomeBalance;
    public int numberOfCustomers;
    public int advertisingBudget;
    public int numberOfProducts;
    public List <Employee> employeeArr;
    public List <Product> productArr;
    public int sumOfSalary;
    public int sumOfSale;
    public int expenses;
    public int revenues;
    public int BusinessEfficiency;

    public State(Store store)
    {
        this.numberOfEmployees = store.numberOfEmployees;
        this.incomeBalance = store.incomeBalance;
        this.numberOfCustomers = store.numberOfCustomers;
        this.advertisingBudget = store.advertisingBudget;
        this.numberOfProducts = store.numberOfProducts;
        this.employeeArr = store.employeeArr;
        this.productArr = store.productArr;
        this.sumOfSalary = calcSumOfSalary(numberOfEmployees, employeeArr);
        this.sumOfSale = calcSumOfSale(numberOfProducts, productArr);
        this.expenses = calcExpenses(numberOfEmployees, employeeArr, advertisingBudget);
        this.revenues = calcRevenues(numberOfProducts, productArr, incomeBalance);
        this.BusinessEfficiency = calcBusinessEfficiency(numberOfEmployees, employeeArr, advertisingBudget, numberOfProducts, productArr, incomeBalance);
    }

    public State(int numberOfEmployees, int incomeBalance, int numberOfCustomers, int advertisingBudget, int numberOfProducts,List <Employee> employeeArr, List <Product> productArr)
    {
        this.numberOfEmployees = numberOfEmployees;
        this.incomeBalance = incomeBalance;
        this.numberOfCustomers = numberOfCustomers;
        this.advertisingBudget = advertisingBudget;
        this.numberOfProducts = numberOfProducts;
        this.employeeArr = employeeArr;
        this.productArr = productArr;
        this.sumOfSalary = calcSumOfSalary(numberOfEmployees, employeeArr);
        this.sumOfSale = calcSumOfSale(numberOfProducts, productArr);
        this.expenses = calcExpenses(numberOfEmployees, employeeArr, advertisingBudget);
        this.revenues = calcRevenues(numberOfProducts, productArr, incomeBalance);
        this.BusinessEfficiency = calcBusinessEfficiency(numberOfEmployees, employeeArr, advertisingBudget, numberOfProducts, productArr, incomeBalance);
    }

    public static int calcSumOfSalary(int numberOfEmployees, List <Employee> employeeArr)
    {
        int sumOfSalary = 0;
        for (int i = 0; i < numberOfEmployees; i++)
        {
            sumOfSalary += employeeArr[i].Salary;
        }
        return sumOfSalary;
    }

    public static int calcSumOfSale(int numberOfProducts, List <Product> productArr)
    {
        int sumOfSale = 0;
        for (int i = 0; i < numberOfProducts; i++)
            sumOfSale += productArr[i].NetProfit;
        return sumOfSale;
    }

    public static int calcExpenses(int numberOfEmployees, List <Employee> employeeArr,int advertisingBudget)
    {
        return calcSumOfSalary(numberOfEmployees, employeeArr) + advertisingBudget;
    }

    public static int calcRevenues(int numberOfProducts, List <Product> productArr, int incomeBalance)
    {
        return calcSumOfSale(numberOfProducts, productArr) + incomeBalance;
    }
    public static int calcBusinessEfficiency(int numberOfEmployees, List<Employee> employeeArr, int advertisingBudget, int numberOfProducts, List<Product> productArr, int incomeBalance)
    {
        return (calcRevenues(numberOfProducts, productArr, incomeBalance)/ calcExpenses(numberOfEmployees, employeeArr, advertisingBudget)) * 100;
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







