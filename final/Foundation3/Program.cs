using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address
        {
            _street = "123 W 456 N",
            _city = "Orem",
            _state = "UT",
            _country = "USA"
        };

        Lecture lecture = new Lecture
        ("Parenting - Good Inside", 
        "Improve your relationship with kids",
        "April 17, 2024",
        "10:00AM-12:00pm",
        address,
        "Dr. Pretty Anderson",
        250);

        Reception reception = new Reception
        ("Mary and John", 
        "Happy Anniversary", 
        "June 11, 2024",
        "5:00pm-8:00pm",
        address,
        "thankyou@gmail.com");

        OutdoorGathering outdoor = new OutdoorGathering
        ("Song Of Heart Singers",
        "50th Birthday",
        "July 29, 2024",
        "6:00pm-9:00pm",
        address,
        "Sunny");

        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GenerateStandardDetails());
        Console.WriteLine(reception.GenerateStandardDetails());
        Console.WriteLine(outdoor.GenerateStandardDetails());

        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lecture.GenerateFullDetails());
        Console.WriteLine(reception.GenerateFullDetails());
        Console.WriteLine(outdoor.GenerateFullDetails());

        Console.WriteLine("\nShort Descriptions:");
        Console.WriteLine(lecture.GenerateShortDecscription());
        Console.WriteLine(reception.GenerateShortDecscription());
        Console.WriteLine(outdoor.GenerateShortDecscription());

    }
}