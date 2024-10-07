// See https://aka.ms/new-console-template for more information
// Program Name: Grams To Pounds Converter
// Date: September 29, 2024
// Author: K Bola
// Purpose: This application converts grams to pounds
namespace GramsToPoundsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePerProduct = 2.09;
            Console.WriteLine("Enter the name of the product: ");
            string productName = Console.ReadLine();
            Console.WriteLine($"Enter the unit of {productName}(in grams): ");
            int grams = Convert.ToInt32(Console.ReadLine());
            double pounds = grams * 0.00220462;
            double price = pounds * pricePerProduct;
            Console.WriteLine($"Product Name: {productName}");
            Console.WriteLine($"Grams: {grams}");
            Console.WriteLine($"Price Per Product: {pricePerProduct.ToString("C")}");
            Console.WriteLine($"Product in pounds: {pounds.ToString("F2")}");
            Console.WriteLine($"Total Cost: {price.ToString("C")}");
        }
    }
}