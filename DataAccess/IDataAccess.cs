using RestaurantObjects;
using System.Collections.Generic;

namespace DataAccess
{
    public interface IDataAccessProducts
    {
        void AddProduct(Product s);
        List<Product> GetProducts();

        List<Product> FilterProducts(bool filter_name, bool filter_info, bool filter_category, string _name, string _info, string _category);
        Product GetProduct(int _number);
        Product SearchByNameP(string _name);
        void UpdateProduct(Product _product);
        void DeleteProduct(Product _product);
        void UpdateProductFile();
    }

    public interface IDataAccessCategories
    {
        void AddCategory(Category s);
        List<Category> GetCategories();
        List<Category> FilterCategories(bool filter_name, bool filter_info, string _name, string _info);
        Category GetCategory(int _number);
        Category SearchByNameC(string _name);
        void DeleteCategory(Category _category);
        void UpdateCategory(Category _category);
        void UpdateCategoryFile();
    }

    public interface IDataAccessTables
    {
        void AddTable(Table s);
        List<Table> GetTables();
        List<Table> FilterTables(int _seats, bool _occupied, bool _reserved, bool status);
        Table GetTable(int _number);
        void DeleteTable(Table _table);
        void UpdateTable(Table _table);
        void UpdateTableFile();
    }

    public interface IDataAccessOrders
    {
        void AddOrder(Order s);
        List<Order> GetOrders();
        List<Order> FilterOrders(bool filter_client, bool filter_status, string _client, string _status);
        Order GetOrder(int _number);
        Order SearchByClientO(string _client);
        Order SearchByNumberO(int _number);
        void UpdateOrder(Order _order);
        void DeleteOrder(Order _order);
        void UpdateOrderFile();
    }
}
