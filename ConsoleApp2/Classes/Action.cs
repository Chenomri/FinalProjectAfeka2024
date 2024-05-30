
public class Action
{
    public ActionType Type;
    public int PercentageChange;
    public bool isMorePercentage;

    public Action(ActionType type, int percentageChange, bool isMorePercentage)
    {
        Type = type;
        PercentageChange = percentageChange;
        this.isMorePercentage = isMorePercentage;
    }

    public ActionType GetActionType()
    {
        return Type;
    }

    public int getPercentageChange()
    {
        return PercentageChange;
    }

    public bool getIsMorePercentage()
    {
        return isMorePercentage; 
    }
    public void setActionType(ActionType type)
    {
         this.Type=type;
    }

    public void setPercentageChange(int percentageChange)
    {
        this.PercentageChange= percentageChange;
    }

    public void setIsMorePercentage(bool isMorePercentage)
    {
        this.isMorePercentage = isMorePercentage;
    }
}

public enum ActionType
{
    AdvertisingBudget,
    SalaryEmployee,
    ProductPrices,
    ProductStock,
    NumberDifferentProducts,
    NumberOfEmployees
}


