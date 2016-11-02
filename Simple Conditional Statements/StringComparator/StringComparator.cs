using System;
 class StringComparator
    {
        static void Main(string[] args)
        {
        string firstWord = Console.ReadLine().ToLower();
        string secindWord = Console.ReadLine().ToLower();
        string tirdthWord = Console.ReadLine().ToLower();


        if (firstWord == secindWord && secindWord == tirdthWord)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

    }
}

