using System;
using RestaurantObjects;

namespace RestaurantConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table();
            Product product = new Product();
            Category category = new Category();
            Order order = new Order();
            Console.ReadKey();
        }
    }
}
