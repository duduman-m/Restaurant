using System;
using DataAccess;
using RestaurantObjects;

namespace RestaurantConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataAccessProducts adminProducts = DataFactory.GetProductsDataAccess();
            IDataAccessCategories adminCategories = DataFactory.GetCategoriesDataAccess();
            IDataAccessTables adminTables = DataFactory.GetTablesDataAccess();
            IDataAccessOrders adminOrders = DataFactory.GetOrdersDataAccess();

            Table.AllTables = adminTables.GetTables();
            Category.AllCategories = adminCategories.GetCategories();
            Product.AllProducts = adminProducts.GetProducts();
            Order.AllOrders = adminOrders.GetOrders();

            //Table test
            Console.WriteLine("\n####### Table test #########");
            Console.WriteLine($"Number of tables: {Table.AllTables.Count}\n");
            foreach (Table t in Table.AllTables)
            {
                Console.WriteLine(t.ConvertToString());
            }


            //Product test
            Console.WriteLine("\n####### Product test #########");
            Console.WriteLine($"Number of products: {Product.AllProducts.Count}\n");
            foreach(Product p in Product.AllProducts)
            {
                Console.WriteLine(p.ConvertToString());
            }
            Product.AllProducts[0].SetName("Pizza Capriciosa");
            adminProducts.UpdateProduct(Product.AllProducts[0]);

            //Category test part 2
            Console.WriteLine("\n####### Category test #########");
            Console.WriteLine($"Number of categories: {Category.AllCategories.Count}\n");
            foreach (Category c in Category.AllCategories)
            {
                Console.WriteLine(c.ConvertToString());
            }

            //Order test
            Console.WriteLine("\n####### Order test #########");
            Console.WriteLine($"Number of orders: {Order.AllOrders.Count}\n");
            foreach (Order o in Order.AllOrders)
            {
                Console.WriteLine(o.ConvertToString());
            }

            //Order order_searched = adminOrders.SearchByClient("George");
            //Console.WriteLine(order_searched.ConvertToString());
            Console.ReadKey();
        }
    }
}
