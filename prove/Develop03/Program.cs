
using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Moroni",7,35,37);

        string verse35 = @"And now, my beloved brethren, if this be the case that these things are true which I have spoken unto you,
            and God will show unto you, with power and great glory at the last day, that they are true, and if they are
            true has the day of miracles ceased?";

        string verse36 = @"Or have angels ceased to appear unto the children of men? Or has he withheld the power of the Holy Ghost
            from them? Or will he, so long as time shall last, or the earth shall stand, or there shall be one man upon
            the face thereof to be saved?";

        string verse37 = @"Behold I say unto you, Nay; for it is by faith that miracles are wrought; and it is by faith that angels
    appear and minister unto men; wherefore, if these things have ceased wo be unto the children of men, for it
    is because of unbelief, and all is vain.";

        string scriptureText = verse35 + Environment.NewLine + verse36 + Environment.NewLine + verse37;

        Scripture scripture = new Scripture(reference, scriptureText);

        DisplayScripture(scripture);

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit: ");
            string input = Console.ReadLine();
            if (input.ToLower()=="quit")
                break;

            scripture.HideRandomwords();
            DisplayScripture(scripture);
        }

        Console.WriteLine("All words are now hidden. Press Enter to exit.");
        Console.ReadLine();

    static void DisplayScripture(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }



    }
}