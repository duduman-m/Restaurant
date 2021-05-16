using System;
using DataAccess;
using RestaurantObjects;

namespace RestaurantConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataAccessProducts adminProducts = ProductDataFactory.GetProductsDataAccess();
            IDataAccessCategories adminCategories = CategoryDataFactory.GetCategoriesDataAccess();
            IDataAccessTables adminTables = TableDataFactory.GetTablesDataAccess();
            IDataAccessOrders adminOrders = OrderDataFactory.GetOrdersDataAccess();

            Log.AllTables = adminTables.GetTables();
            Log.AllCategories = adminCategories.GetCategories();
            Log.AllProducts = adminProducts.GetProducts();
            //Log.AllOrders = adminOrders.GetOrders();

            //Table test
            Console.WriteLine("\n####### Table test #########");
            Console.WriteLine($"Number of tables: {Log.AllTables.Count}\n");
            foreach (Table t in Log.AllTables)
            {
                Console.WriteLine(t.ConvertToString());
            }


            //Product test
            Console.WriteLine("\n####### Product test #########");
            Console.WriteLine($"Number of products: {Log.AllProducts.Count}\n");
            foreach(Product p in Log.AllProducts)
            {
                Console.WriteLine(p.ConvertToString());
            }
            adminProducts.UpdateProduct(Log.AllProducts[0]);

            //Category test part 2
            Console.WriteLine("\n####### Category test #########");
            Console.WriteLine($"Number of categories: {Log.AllCategories.Count}\n");
            foreach (Category c in Log.AllCategories)
            {
                Console.WriteLine(c.ConvertToString());
            }

            //Order test
            Console.WriteLine("\n####### Order test #########");
            Console.WriteLine($"Number of orders: {Log.AllOrders.Count}\n");
            foreach (Order o in Log.AllOrders)
            {
                Console.WriteLine(o.ConvertToString());
            }

            //Order order_searched = adminOrders.SearchByClient("George");
            //Console.WriteLine(order_searched.ConvertToString());
            Console.ReadKey();
        }
    }
}
