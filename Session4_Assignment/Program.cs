using System;

namespace Session4_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Every question setted into #region and #endregion to make it easy to test each question by commenting the
            // uncommented code inside any region  and run it to test the assignment question.
            // waiting for any notes exist
            #region Q1

            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(prices[1]);
            #endregion
            //-------------------------------------------------------------------------------------------
            #region Q2

            // int[,] shelfCopies = {
            //     {3, 5},
            //     {1, 4}
            // };

            // Console.WriteLine(shelfCopies[1,0]);
            #endregion
            //-------------------------------------------------------------------------------------------
            #region Q3

            //    PrintWelcomeMessage(); // see the method implementaion below
            #endregion
            //-------------------------------------------------------------------------------------------
            #region Q4

            //    PrintBookTitle("Clean Code"); // see the method implementaion below

            #endregion
            //-------------------------------------------------------------------------------------------
            #region Q5

            //    int pages = 400;
            //    AddBonusPages(pages);
            //    Console.WriteLine(pages); // output 400 , Because value types like int passed by value by default.

            #endregion
            //-------------------------------------------------------------------------------------------
            #region Q6

            // double[] prices = { 25.5, 40.0 };
            // ApplyDiscount(prices);
            // Console.WriteLine(prices[0]);         
            // Output 20.5 , Because arrays are reference types in C#.
            // Both the original variable and the method parameter refer to the same array in memory
            // prices[0] -= 5; modifies the first element of that original array.
            // When the method finishes, the change remains.
            #endregion
            //-------------------------------------------------------------------------------------------
            #region Q7

            //    int pages = 400;
            //    AddBonusPagesByRef(ref pages);
            //    Console.WriteLine(pages); 
            // output 450 , Because passes the variable by reference which modifies original variable
            //pages += 50; adds 50 to the original variable.

            #endregion
            //-------------------------------------------------------------------------------------------
            #region Q8

            // double[] prices = { 25.5, 40.0 };
            // ReplaceArray(ref prices);
            // Console.WriteLine(prices.Length);

            #endregion
            //-------------------------------------------------------------------------------------------
            #region Q9

            // string title = "Clean Code";
            // bool isPriced = TryGetPrice(title, out double price);

            // Console.WriteLine(isPriced);
            // Console.WriteLine(price);

            #endregion
            //-------------------------------------------------------------------------------------------
            #region Q10 , Q11
            // string title = "C# Basics by Route";

            // PrintBookInfo(title);
            // PrintBookInfo(title, 500);

            // PrintBookInfo(pages: 450, title: title); // Q11

            #endregion
            //-------------------------------------------------------------------------------------------
            #region Q12

            // string title1 = "C# Basics";
            // string title2 = "C# Advanced";
            // string title3 = ".Net Framework";
            // PrintAllTitles(title1, title2, title3);

            #endregion
            //-------------------------------------------------------------------------------------------
        }
        //-------------------------------------------------------------------------------------------
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        //-------------------------------------------------------------------------------------------
        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }
        //-------------------------------------------------------------------------------------------
        static void AddBonusPages(int pages)
        {
            pages += 50;
        }
        //-------------------------------------------------------------------------------------------
        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
        //-------------------------------------------------------------------------------------------
        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }
        //-------------------------------------------------------------------------------------------
        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
        //-------------------------------------------------------------------------------------------
        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 2.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }
        //-------------------------------------------------------------------------------------------
        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Title:{title} , Pages: {pages}");
        }
        //-------------------------------------------------------------------------------------------
        static void PrintAllTitles(params string[] titles)
        {
            foreach (string title in titles)
            {
                Console.WriteLine(title);
            }

        }
        //-------------------------------------------------------------------------------------------
    }
}
