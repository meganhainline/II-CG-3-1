using System;

namespace II_CG_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1-12");

            string userValue = Console.ReadLine();
            string message = "";


            if (userValue == "1")
                message = "January";
            else if (userValue == "2")
                message = "February";
            else if (userValue == "3")
                message = "March";
            else if (userValue == "4")
                message = "April";
            else if (userValue == "5")
                message = "May";
            else if (userValue == "6")
                message = "June";
            else if (userValue == "7")
                message = "July";
            else if (userValue == "8")
                message = "August";
            else if (userValue == "9")
                message = "September";
            else if (userValue == "10")
                message = "October";
            else if (userValue == "11")
                message = "November";
            else if (userValue == "12")
                message = "December";
            else
                message = "Sorry, I don't understand.";

            Console.WriteLine(message);
                    Console.ReadLine();

            




        }
    }
}
