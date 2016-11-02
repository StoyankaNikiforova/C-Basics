using System;

class Numbers1to100
{
    static void Main()
    {
        string numberSeq = Console.ReadLine();

        int countOfdigit = numberSeq.Length;
        if (int.Parse(numberSeq) > 100 || int.Parse(numberSeq) < 0)
        {
            Console.WriteLine("invalid number");
        }
        else
        {
            switch (countOfdigit)
            {
                case 1:
                    Console.WriteLine(unitsInString(numberSeq));
                    break;
                case 2:
                    if (numberSeq[0].ToString() == "1")
                    {
                        Console.WriteLine(digitsToTeen(numberSeq[1].ToString()));
                    }
                    else if (numberSeq[1].ToString() == "0")
                    {
                        Console.WriteLine(tentsInString(numberSeq[0].ToString()));
                    }
                    else
                    {
                        string units = unitsInString(numberSeq[1].ToString());
                        string tents = tentsInString(numberSeq[0].ToString());
                        Console.WriteLine("{0} {1}", tents, units);
                    }
                    break;
                case 3:
                    Console.WriteLine("one hundred");
                    break;
            }
        }
    }
        static string unitsInString(string number)
        {
            string numberInStr = "";
            switch (number)
            {
                case "0":
                    numberInStr = "zero";
                    break;
                case "1":
                    numberInStr = "one";
                    break;
                case "2":
                    numberInStr = "two";
                    break;
                case "3":
                    numberInStr = "three";
                    break;
                case "4":
                    numberInStr = "four";
                    break;
                case "5":
                    numberInStr = "five";
                    break;
                case "6":
                    numberInStr = "six";
                    break;
                case "7":
                    numberInStr = "seven";
                    break;
                case "8":
                    numberInStr = "eight";
                    break;
                case "9":
                    numberInStr = "nine";
                    break;

            }
            return numberInStr;
        }
        static string digitsToTeen(string number)
    {
            string numberInStr = "";
            switch (number)
            {
                case "0":
                    numberInStr = "ten";
                    break;
                case "1":
                    numberInStr = "eleven";
                    break;
                case "2":
                    numberInStr = "twelve";
                    break;
                case "3":
                    numberInStr = "thirteen";
                    break;
                case "4":
                    numberInStr = "fourteen";
                    break;
                case "5":
                    numberInStr = "fifteen";
                    break;
                case "6":
                    numberInStr = "sixteen";
                    break;
                case "7":
                    numberInStr = "seventeen";
                    break;
                case "8":
                    numberInStr = "eighteen";
                    break;
                case "9":
                    numberInStr = "nineteen";
                    break;

            }
            return numberInStr;
        }
        static string tentsInString(string number)
    {
            string numberInStr = "";
            switch (number)
            {
                case "2":
                    numberInStr = "twenty";
                    break;
                case "3":
                    numberInStr = "thirty";
                    break;
                case "4":
                    numberInStr = "fourty";
                    break;
                case "5":
                    numberInStr = "fifty";
                    break;
                case "6":
                    numberInStr = "sixty";
                    break;
                case "7":
                    numberInStr = "seventy";
                    break;
                case "8":
                    numberInStr = "eighty";
                    break;
                case "9":
                    numberInStr = "ninety";
                    break;

            }
            return numberInStr;
        }
    
}

