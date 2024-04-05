public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GenerateFullDetails()
    {
        return base.GenerateFullDetails() + $"Type: Reception\nRSVP Email: {_rsvpEmail}\n";
    }

        public override string GenerateShortDecscription()
    {
        return $"Type of Event: Reception\nEvent Title: {_title}\nDate: {_date}\n";
    }
}