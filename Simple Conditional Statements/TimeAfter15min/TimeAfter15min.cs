using System;
class TimeAfter15min
    {
        static void Main(string[] args)
        {
            int inputHour = int.Parse(Console.ReadLine());
            int inputMinutes = int.Parse(Console.ReadLine());

        TimeSpan time = new TimeSpan(inputHour, inputMinutes + 15,0);

        Console.WriteLine(time.ToString("h\\:mm"));

    }
}

