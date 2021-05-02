using RestaurantObjects;
using System;
using System.Collections;
using System.Collections.Generic;

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

        public Product SearchByNumberP(int _number)
        {
            return Product.AllProducts.Find(c => c.GetNumber() == _number);
        }

        public Product SearchByNameP(string _name)
        {
            return Product.AllProducts.Find(c => c.GetName() == _name);
        }

        public void UpdateProduct(Product _product)
        {
            throw new Exception("Not implemented yet");
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

        public Category SearchByNumberC(int _number)
        {
            return Category.AllCategories.Find(c => c.GetNumber() == _number);
        }

        public Category SearchByNameC(string _name)
        {
            return Category.AllCategories.Find(c => c.GetName() == _name);
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

        public Table SearchByNumberT(int _number)
        {
            return Table.AllTables.Find(t => t.GetNumber() == _number);
        }

        public void UpdateTable(Table _table)
        {
            throw new Exception("Not implemented yet");
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

        public Order SearchByClientO(string _client)
        {
            return Order.AllOrders.Find(o => o.GetClient() == _client);
        }

        public Order SearchByNumberO(int _number)
        {
            return Order.AllOrders.Find(o => o.GetNumber() == _number);
        }

        public void UpdateOrder(Order _order)
        {
            throw new Exception("Not implemented yet");
        }

        public void UpdateOrderFile()
        {
            throw new Exception("Not implemented yet");
        }

    }
}
