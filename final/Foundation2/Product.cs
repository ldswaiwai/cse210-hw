public class Product
{
    private string _name;
    private string _productId;
    private decimal _pricePerUnit;
    private int _quantity;

    public Product(string name, string productId, decimal pricePerUnit, int quantity)
    {
        this._name = name;
        this._productId = productId;
        this._pricePerUnit = pricePerUnit;
        this._quantity = quantity;

    }

    public decimal CalculateTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    public string Name {get=> _name;}
    public string ProductId {get=> _productId;}
    public decimal PricePerUnit {get=> _pricePerUnit;}
    public int Quantity {get=> _quantity;}


}