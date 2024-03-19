using System.Runtime.CompilerServices;

public class Assignment
{
    protected string _studentName;
    private string _topic;

    public Assignment(string studenName, string topic)
    {
        _studentName = studenName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    } 


}
