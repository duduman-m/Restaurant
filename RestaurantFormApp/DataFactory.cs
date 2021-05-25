using DataAccess;
using System.Configuration;

namespace RestaurantFormApp
{
    class ProductDataFactory
    {
        private const string SAVING_FORMAT = "FileFormat";
        private const string PRODUCTS_FILE_NAME = "ProductsFileName";
        public static IDataAccessProducts GetProductsDataAccess()
        {
            var saving_format = ConfigurationManager.AppSettings[SAVING_FORMAT];
            var file_name = ConfigurationManager.AppSettings[PRODUCTS_FILE_NAME];
            if (saving_format != null)
            {
                switch (saving_format)
                {
                    default:
                    case "bin":
                        return new Binary_File_Administration(file_name + "." + saving_format);
                    case "txt":
                        return new Text_File_Administration(file_name + "." + saving_format);
                }
            }

            return null;
        }
    }

    class CategoryDataFactory
    {
        private const string SAVING_FORMAT = "FileFormat";
        private const string CATEGORIES_FILE_NAME = "CategoriesFileName";

        public static IDataAccessCategories GetCategoriesDataAccess()
        {
            var saving_format = ConfigurationManager.AppSettings[SAVING_FORMAT];
            var file_name = ConfigurationManager.AppSettings[CATEGORIES_FILE_NAME];
            if (saving_format != null)
            {
                switch (saving_format)
                {
                    default:
                    case "bin":
                        return new Binary_File_Administration(file_name + "." + saving_format);
                    case "txt":
                        return new Text_File_Administration(file_name + "." + saving_format);
                }
            }

            return null;
        }
    }

    class TableDataFactory
    {
        private const string SAVING_FORMAT = "FileFormat";
        private const string TABLES_FILE_NAME = "TablesFileName";

        public static IDataAccessTables GetTablesDataAccess()
        {
            var saving_format = ConfigurationManager.AppSettings[SAVING_FORMAT];
            var file_name = ConfigurationManager.AppSettings[TABLES_FILE_NAME];
            if (saving_format != null)
            {
                switch (saving_format)
                {
                    default:
                    case "bin":
                        return new Binary_File_Administration(file_name + "." + saving_format);
                    case "txt":
                        return new Text_File_Administration(file_name + "." + saving_format);
                }
            }

            return null;
        }
    }

    class OrderDataFactory
    {
        private const string SAVING_FORMAT = "FileFormat";
        private const string ORDERS_FILE_NAME = "OrdersFileName";

        public static IDataAccessOrders GetOrdersDataAccess()
        {
            var saving_format = ConfigurationManager.AppSettings[SAVING_FORMAT];
            var file_name = ConfigurationManager.AppSettings[ORDERS_FILE_NAME];
            if (saving_format != null)
            {
                switch (saving_format)
                {
                    default:
                    case "bin":
                        return new Binary_File_Administration(file_name + "." + saving_format);
                    case "txt":
                        return new Text_File_Administration(file_name + "." + saving_format);
                }
            }

            return null;
        }
    }

    class FeedbackDataFactory
    {
        private const string SAVING_FORMAT = "FileFormat";
        private const string ORDERS_FILE_NAME = "FeedbacksFileName";

        public static IDataAccessFeedbacks GetFeedbacksDataAccess()
        {
            var saving_format = ConfigurationManager.AppSettings[SAVING_FORMAT];
            var file_name = ConfigurationManager.AppSettings[ORDERS_FILE_NAME];
            if (saving_format != null)
            {
                switch (saving_format)
                {
                    default:
                    case "bin":
                        return new Binary_File_Administration(file_name + "." + saving_format);
                    case "txt":
                        return new Text_File_Administration(file_name + "." + saving_format);
                }
            }

            return null;
        }
    }
}
