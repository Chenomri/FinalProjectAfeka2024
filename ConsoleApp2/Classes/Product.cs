public class Product
{
    public int Id { get; set; }
    public int NetProfit;
    public int StockSize; 

    public Product(int id, int netProfit, int numberOfProductsInStock)
    {
        Id = id;
        NetProfit = netProfit;
        StockSize = numberOfProductsInStock;
    }
    public int getId()
    {
        return Id; 
    }
    public int GetStockSize()
    { 
        return StockSize;
    }

    public int GetNetProfit()
    {
        return NetProfit;
    }

    public void setId(int id)
    {
        this.Id = id;
    }

    public void setStockSize(int stockSize)
    {
        this.StockSize = stockSize;
    }

    public void setNetProfit(int netProfit)
    {
        this.NetProfit = netProfit;
    }


    public override string ToString()
    {
        return $"Net profit: {NetProfit}\n" +
               $"Number of products in stock: {StockSize}";
    }
}