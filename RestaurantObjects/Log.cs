using System.Collections.Generic;

namespace RestaurantObjects
{
    public class Log
    {
        public static List<Table> AllTables = new List<Table>();
        public static List<Category> AllCategories = new List<Category>();
        public static List<Product> AllProducts = new List<Product>();
        public static List<Order> AllOrders = new List<Order>();
        public static List<Feedback> AllFeedbacks = new List<Feedback>();

        public static int GetMaxLengthCategoryName()
        {
            int max = 5;
            foreach (Category c in AllCategories)
            {
                if (c.name.Length > max)
                    max = c.name.Length;
            }
            return max + 5;
        }

        public static int GetMaxLengthProductName()
        {
            int max = 5;
            foreach (Product p in AllProducts)
            {
                if (p.name.Length > max)
                    max = p.name.Length;
            }
            return max + 5;
        }

        public static int GetMaxLengthOrderClient()
        {
            int max = 5;
            foreach (Order o in AllOrders)
            {
                if (o.client.Length > max)
                    max = o.client.Length;
            }
            return max + 5;
        }
    }
}
