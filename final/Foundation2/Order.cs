using System.Globalization;
using System.Runtime.CompilerServices;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        this._customer = customer;
        _products =  new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalPrice()
    {
        decimal _totalCost = _products.Sum(_product => _product.CalculateTotalCost());
        return _totalCost + (_customer.IsInUSA() ? 5: 35);
    }

    public string GetPackingLabel()
    {
        string packingLabel = $"Packing Lable: \nCustomer Name: {_customer.GetName()}\n";
        foreach (var product in _products)
        {
            packingLabel += $"Product Name: {product.Name}, Product ID: {product.ProductId}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"Shipping Label:\nCustomer Name: {_customer.GetName()}\n";
        shippingLabel += $"Customer Address:\n{_customer.GetAddressString()}\n";
        return shippingLabel;
    }

}