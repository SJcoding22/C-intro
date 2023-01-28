using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("What day of the week is it?");
        string day = Console.ReadLine();
        // int day = 1
        // int day = Convert.ToInt32(Console.ReadLine());
        switch (day)
        {
            case "Mon" or "monday":
                Console.WriteLine("Today is... Monday");
                Console.WriteLine("~Go school now~");
                break;
            case "Tue" or "tuesday":
                Console.WriteLine("Tuesday");
                Console.WriteLine("~Do your homework~");
                break;
            case "Wed" or "wednesday":
                Console.WriteLine("Wednesday");
                Console.WriteLine("~play games~");
                break;
            case "Thur" or "thursday":
                Console.WriteLine("Thursday");
                Console.WriteLine("~Go to English academy~");
                break;
            case "Fri" or "friday":
                Console.WriteLine("Friday!!!!");
                Console.WriteLine("~Go to Math academy and sleep~");
                break;
            case "Sat" or "saturday":
                Console.WriteLine("Saturday!!!!");
                Console.WriteLine("~Let's go coding academy!~");
                break;
            case "Sun" or "sunday":
                Console.WriteLine("Sunday!!!!");
                Console.WriteLine("~Play KARTRIDER!~");
                break;
        }
    }
}