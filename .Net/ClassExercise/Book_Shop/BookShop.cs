using System.Diagnostics;

namespace Book_Shop
{
    internal class Program
    {
        static string book_title = "";
        static string author = "";
        static float price = 0.0f;
        static string book_to_sell = "";
        static int sell_quantity = 0;
        static string customer_name = "";
        static int quantity = 0;
        static void Main(string[] args)
        {
            int choice = 0;
            while(choice != 5)
            {
                Console.WriteLine("====== BOOK SHOP MENU ======");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Sell Book");
                Console.WriteLine("3. View Books");
                Console.WriteLine("4. View Sales Report");
                Console.WriteLine("5. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddBook();
                        Console.WriteLine();
                        break;
                    case 2:
                        SellBook();
                        Console.WriteLine();
                        break;
                    case 3:
                        ViewBooks();
                        Console.WriteLine();
                        break;
                    case 4:
                        ViewSalesReport();
                        Console.WriteLine();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }




            

        }
        static void AddBook()
        {
            Console.WriteLine("Enter book title :");
            book_title = Console.ReadLine();
            Console.WriteLine("Enter author :");
            author = Console.ReadLine();
            Console.WriteLine("Enter price :");
            price = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter quantity :");
            quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Book added successfully.");
        }
        static void SellBook()
        {
            Console.WriteLine("Enter book title to sell :");
            book_to_sell = Console.ReadLine();
            Console.WriteLine("Enter quantity to sell :");
            sell_quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter customer name :");
            customer_name = Console.ReadLine();
            Console.WriteLine($"Sold {sell_quantity} copies of {book_to_sell} to {customer_name}.");

        }
        static void ViewBooks()
        {
            string bookInfo = $"Book Title: {book_title}\nAuthor: {author}\nPrice: {price}\nQuantity: {sell_quantity}";
            Console.WriteLine(bookInfo);
        }
        static void ViewSalesReport()
        {
            string saleInfo = $"Customer Name: {customer_name}\nBook Sold: {book_to_sell}\nQuantity Sold: {sell_quantity}\nAmount: {sell_quantity * price}";
            Console.WriteLine(saleInfo);
        }
    }
}
