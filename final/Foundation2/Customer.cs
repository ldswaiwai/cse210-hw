using System.Buffers;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(String name, Address address)
    {
        this._name = name;
        this._address = address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddressString()
    {
        return _address.GetFormattedAddress();
    }


}