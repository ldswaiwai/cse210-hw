using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string userValue = Console.ReadLine();
        int x = int.Parse(userValue);

        string letter = "";
        string sign = "";

        if (x >=90 )
        {
            letter = "A";
        }
        else if (x<90 && x>=80)
        {
            letter = "B";
        }
        else if (x<80 && x>=70)
        {
            letter = "C";
        }
        else if (x<70 && x>=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (x%10 >= 7)
        {
            sign = "+";
        }
        else if (x%10 <3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (letter=="A" && x%10>=7)
        {
            sign = "";
        }
        if (letter=="F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is {letter}{sign}");

        if (letter=="A" || letter=="B" || letter=="C")
        {
            Console.WriteLine("Congratulations! You pass the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you don't pass the class. Try harder next time.");
        }

    }
}