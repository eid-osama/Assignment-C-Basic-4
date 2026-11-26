namespace Assignment_C_Basic_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion
            #region Question 2
            //int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            //Console.WriteLine(shelfCopies[1, 0]);
            #endregion
            #region Question 3
            //PrintWelcomeMessage();
            #endregion
            #region Question 4
            //PrintBookTitle("Clean Code");
            #endregion
            #region Question 5
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages);
            // pages = 400, because that was call by value meaning the method had a copy of the variable ,so it did not change the original variable
            #endregion
            #region Question 6
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            // prices[0] = 20.5 , because we passed the reference of the array so the methode can change the array without making a copy
            #endregion
            #region Question 7
            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine(pages);
            // pages = 450, because we passed the reference of the variable so the method did not make a copy but changed the original variable
            #endregion
            #region Question 8
            //double[] prices = { 25.5, 40.0 };
            //ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);
            #endregion
            #region Question 9
            //double price;
            //bool priceFound = TryGetPrice("Clean Code", out price);
            //Console.WriteLine(price);
            #endregion
            #region Question 10
            //PrintBookInfo("Clead code");
            //PrintBookInfo("Design pattern",450);
            #endregion
            #region Question 11
            //PrintBookInfo(pages : 450, title : "Design pattern");
            #endregion
            #region Question 12
            //PrintAllTitles("Clean Code", "C#", "Java");
            #endregion

        }
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        public static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }
        public static void AddBonusPages(int pages)
        {
            pages += 50;
        }
        public static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
        public static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }
        public static void ReplaceArray(ref double[] prices)
        {
            Array.Resize<double>(ref prices, 3);
            double[] changedPrices = { 10.0, 12.5, 15.0 };
            for (int i = 0; i < prices.Length; i++)
            { 
                prices[i] = changedPrices[i];
            }
        }
        public static bool TryGetPrice(string title, out double price)
        {
            if(title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            price = 0;
            return false;
        }
        public static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Book title: {title}, pages = {pages}");
        }
        public static void PrintAllTitles(params string[] titles) { 
            foreach(string title in titles)
            {
                Console.WriteLine(title);
            }
        }
    }
}
