using RestaurantObjects;
using System.Collections.Generic;

namespace DataAccess
{
    public interface IDataAccessProducts
    {
        void AddProduct(Product s);
        List<Product> GetProducts();
        Product SearchByNumberP(int _number);
        Product SearchByNameP(string _name);
        void UpdateProduct(Product _product);
        void UpdateProductFile();
    }

    public interface IDataAccessCategories
    {
        void AddCategory(Category s);
        List<Category> GetCategories();
        Category SearchByNumberC(int _number);
        Category SearchByNameC(string _name);
        void UpdateCategory(Category _category);
        void UpdateCategoryFile();
    }

    public interface IDataAccessTables
    {
        void AddTable(Table s);
        List<Table> GetTables();
        Table SearchByNumberT(int _number);
        void UpdateTable(Table _table);
        void UpdateTableFile();
    }

    public interface IDataAccessOrders
    {
        void AddOrder(Order s);
        List<Order> GetOrders();
        Order SearchByClientO(string _client);
        Order SearchByNumberO(int _number);
        void UpdateOrder(Order _order);
        void UpdateOrderFile();
    }
}
