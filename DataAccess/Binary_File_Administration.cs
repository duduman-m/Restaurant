using RestaurantObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class Binary_File_Administration : IDataAccessProducts, IDataAccessCategories, IDataAccessTables, IDataAccessOrders
    {
        string FileName { set; get; }

        public Binary_File_Administration(string _FileName)
        {
            FileName = _FileName;
        }

        public void AddProduct(Product p)
        {
            throw new Exception("Not implemented yet");
        }

        public List<Product> GetProducts()
        {
            throw new Exception("Not implemented yet");
        }

        public List<Product> FilterProducts(bool filter_name, bool filter_info, bool filter_category, string _name, string _info, string _category)
        {
            List<Product> filtered = Log.AllProducts;
            if (filter_name)
            {
                filtered = filtered.FindAll(c => c.name.ToLower().Contains(_name.ToLower()));
            }
            if (filter_info)
            {
                filtered = filtered.FindAll(c => c.info.ToLower().Contains(_info.ToLower()));
            }

            if (filter_category)
            {
                Category cat = SearchByNameC(_category);
                filtered = filtered.FindAll(c => c.CheckCategory(cat));
            }
            return filtered;
        }

        public Product GetProduct(int _number)
        {
            return Log.AllProducts.Find(c => c.number == _number);
        }

        public Product SearchByNameP(string _name)
        {
            return Log.AllProducts.Find(c => c.name == _name);
        }

        public void UpdateProduct(Product _product)
        {
            throw new Exception("Not implemented yet");
        }

        public void DeleteProduct(Product _product)
        {
            Log.AllProducts.Remove(_product);
            UpdateProductFile();
        }

        public void UpdateProductFile()
        {
            throw new Exception("Not implemented yet");
        }

        public void AddCategory(Category c)
        {
            throw new Exception("Not implemented yet");
        }

        public List<Category> GetCategories()
        {
            throw new Exception("Not implemented yet");
        }

        public List<Category> FilterCategories(bool filter_name, bool filter_info, string _name, string _info)
        {
            List<Category> filtered = Log.AllCategories;
            if (filter_name)
            {
                filtered = filtered.FindAll(c => c.name.ToLower().Contains(_name.ToLower()));
            }
            if (filter_info)
            {
                filtered = filtered.FindAll(c => c.info.ToLower().Contains(_info.ToLower()));
            }
            return filtered;
        }

        public Category GetCategory(int _number)
        {
            return Log.AllCategories.Find(c => c.number == _number);
        }

        public Category SearchByNameC(string _name)
        {
            return Log.AllCategories.Find(c => c.name.Equals(_name));
        }

        public void DeleteCategory(Category _category)
        {
            Log.AllCategories.Remove(_category);
            UpdateCategoryFile();
        }

        public void UpdateCategory(Category _category)
        {
            throw new Exception("Not implemented yet");
        }

        public void UpdateCategoryFile()
        {
            throw new Exception("Not implemented yet");
        }

        public void AddTable(Table t)
        {
            throw new Exception("Not implemented yet");
        }

        public List<Table> GetTables()
        {
            throw new Exception("Not implemented yet");
        }

        public List<Table> FilterTables(int _seats, bool _ocupied, bool _reserved, bool status)
        {
            List<Table> filtered = Log.AllTables;
            if (_seats != -1)
            {
                filtered = filtered.FindAll(t => t.seats == _seats);
            }
            if (status)
            {
                filtered = filtered.FindAll(t => (t.occupied == _ocupied && t.reserved == _reserved));
            }
            return filtered;
        }

        public Table GetTable(int _number)
        {
            return Log.AllTables.Find(t => t.number == _number);
        }

        public void UpdateTable(Table _table)
        {
            throw new Exception("Not implemented yet");
        }

        public void DeleteTable(Table _table)
        {
            Log.AllTables.Remove(_table);
            UpdateTableFile();
        }

        public void UpdateTableFile()
        {
            throw new Exception("Not implemented yet");
        }

        public void AddOrder(Order o)
        {
            throw new Exception("Not implemented yet");
        }

        public List<Order> GetOrders()
        {
            throw new Exception("Not implemented yet");
        }

        public List<Order> FilterOrders(bool filter_client, bool filter_status, string _client, string _status)
        {
            List<Order> filtered = Log.AllOrders;
            if (filter_client)
            {
                filtered = filtered.FindAll(o => o.client.ToLower().Contains(_client.ToLower()));
            }
            if (filter_status)
            {
                filtered = filtered.FindAll(o => o.status.ToString().Equals(_status));
            }
            return filtered;
        }

        public Order GetOrder(int _number)
        {
            return Log.AllOrders.Find(o => o.number == _number);
        }

        public Order SearchByClientO(string _client)
        {
            return Log.AllOrders.Find(o => o.client == _client);
        }

        public Order SearchByNumberO(int _number)
        {
            return Log.AllOrders.Find(o => o.number == _number);
        }

        public void UpdateOrder(Order _order)
        {
            throw new Exception("Not implemented yet");
        }

        public void DeleteOrder(Order _order)
        {
            Log.AllOrders.Remove(_order);
            UpdateOrderFile();
        }

        public void UpdateOrderFile()
        {
            throw new Exception("Not implemented yet");
        }

    }
}
