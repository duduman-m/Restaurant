using System;
using RestaurantObjects;

namespace RestaurantConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Table test
            Table table = new Table("4,no,yes");
            Console.WriteLine("\n####### Table test #########");
            Console.WriteLine($"Number of tables: {Table.Table_numbers}\n");
            Console.WriteLine(table.ConvertToString());

            //Category test
            Category category = new Category("Pizza,This is the pizza category");
            Category category_2 = new Category("Drinks,This is the drinks category");
            Category category_3 = new Category("Sauces,This is the sauces category");

            //Product test
            Product product = new Product("Pizza Capriciosa,Fresh italian inspired pizza,25,500,30");
            product.SetCategory(category);
            Product product_2 = new Product("Coca-Cola Zero,The same old Coca-Cola taste now with zero sugar,2,250,1");
            product_2.SetCategory(category_2);
            Product product_3 = new Product("Sweet tomato sauce,Made from fresh local tomatoes,1,50,1");
            product_3.SetCategory(category_3);
            Console.WriteLine("\n####### Product test #########");
            Console.WriteLine($"Number of products: {Product.Product_numbers}\n");
            Console.WriteLine(product.ConvertToString());
            Console.WriteLine(product_2.ConvertToString());
            Console.WriteLine(product_3.ConvertToString());
            Console.WriteLine(product.CompareProductPrices(product_2));

            //Category test part 2
            Console.WriteLine("\n####### Category test #########");
            Console.WriteLine($"Number of categories: {Category.Category_numbers}\n");
            Console.WriteLine(category.ConvertToString());
            Console.WriteLine(category_2.ConvertToString());
            Console.WriteLine(category_3.ConvertToString());

            //Order test
            Order order = new Order("George,Wants the soda with ice,10,Done");
            order.SetTable(table);
            order.AddProduct(product);
            order.AddProduct(new Product[] { product_2, product_3 });
            Console.WriteLine("\n####### Order test #########");
            Console.WriteLine($"Number of orders: {Order.Order_numbers}\n");
            Console.WriteLine(order.ConvertToString());

            Console.ReadKey();
        }
    }
}
