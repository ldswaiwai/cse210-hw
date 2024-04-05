public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        this._streetAddress = street;
        this._city = city;
        this._state = state;
        this._country = country;
    }

    public bool IsInUSA()
    {
        return _country == "USA";
    }

    public string GetFormattedAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}, {_country}";
    }

}