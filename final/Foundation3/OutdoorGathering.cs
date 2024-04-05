public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GenerateFullDetails()
    {
        return base.GenerateFullDetails() + $" Type: Ourdoor Gathering\nWeather Forecast: {_weatherForecast}\n";
    }

    public override string GenerateShortDecscription()
    {
        return $"Type of Event: Outdoor Gathering\nEvent Title: {_title}\nDate: {_date}\n";
    }

}