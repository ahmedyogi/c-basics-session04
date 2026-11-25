using System;
using System.Text;
// using ConsoleApp1;



internal class Program
{
    static void Main(string[] args)
    {
        // task1
        double[] prices = { 25.5, 40, 33.75 };
        Console.WriteLine(prices[1]);

        // task2
        int[,] shelfCopies =
        {
            {3, 5},
            {1, 4}

        };
        Console.WriteLine(shelfCopies[1, 0]);

        // task 3
        PrintWelcomeMessage();

        // task 4
        PrintBookTitle("Clean Code");

        // task 5
        int pages = 400;
        AddBonusPages(pages);

        Console.WriteLine(pages);    // it will be 400 because we passed by value

        // Task 6
        ApplyDiscount(prices);
        Console.WriteLine(prices[0]); //it will subtract 5 from the first index

        // task 7
        AddBonusPagesByRef(ref pages);
        Console.WriteLine(pages); // it will print 450 because we passed by refrence 

        // task 8
        ReplaceArray(ref prices);
        Console.WriteLine(prices.Length);

        // task 9
        string title = "Clean Code";
        double price = 0;
        TryGetPrice(title, out price);

        // task 10
        PrintBookInfo(title);
        PrintBookInfo(title, pages);

        // task 11
        PrintBookInfo(pages: pages, title: title);

        // task 12
        string[] titles = {"title1", "title2", "title3"};
        PrintAllTitles(titles);

    }


    static void PrintWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Library!");
    }

    static void PrintBookTitle(string title)
    {
        Console.WriteLine($"Book title: {title}");
    }
    static void AddBonusPages(int pages)
    {
        pages += 50;
    }
    static void ApplyDiscount(double[] prices)
    {
        prices[0] -= 5;
    }

    static void AddBonusPagesByRef(ref int pages)
    {
        pages += 50;
    }
    static void ReplaceArray(ref double[] prices)
    {
        prices[0] = 10;
        prices[1] = 12.5;
        prices[2] = 15;
    }
    static bool TryGetPrice(string title, out double price)
    {
        // title = "Clean Code" ? price = price = 25.5 && return true:
        if(title == "Clean Code")
        {
            price = 25.5;
            return true;
        }
        else
        {
            price = 0;
            return false;
        }
    }

    static void PrintBookInfo(string title, int pages = 300)
    {
        Console.WriteLine($"book title: {title}, pages: {pages}");
    }

    static void PrintAllTitles(params string[] titles)
    {
        for(int i =0; i<= 2; i++)
        {
            Console.WriteLine(titles[i]);
        }
    }


}