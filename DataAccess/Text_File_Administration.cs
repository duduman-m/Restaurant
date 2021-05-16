using RestaurantObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataAccess
{
    public class Text_File_Administration : IDataAccessProducts, IDataAccessCategories, IDataAccessTables, IDataAccessOrders
    {
        string FileName { set; get; }

        public Text_File_Administration(string _FileName)
        {
            FileName = _FileName;
            using (Stream sFisierText = File.Open(FileName, FileMode.OpenOrCreate)) { };
        }

        private void UpgradeAllFiles()
        {
            UpdateTableFile();
            UpdateCategoryFile();
            UpdateProductFile();
            UpdateOrderFile();
        }

        public void AddProduct(Product p)
        {
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(FileName, true))
                {
                    swFisierText.WriteLine(p.ConvertToFileString());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("The file couldn't be open. Error: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Generric Error: " + eGen.Message);
            }
        }

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            try
            {
                using (StreamReader sr = new StreamReader(FileName))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Product FileProduct = new Product(line);
                        products.Add(FileProduct);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("The file couldn't be open. Error: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Generric Error: " + eGen.Message);
            }

            return products;
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
            for (int i = 0; i < Log.AllProducts.Count; i++)
            {
                if (Log.AllProducts[i] == _product)
                {
                    Log.AllProducts[i] = _product;
                }
            }
            UpdateProductFile();
        }

        public void DeleteProduct(Product _product)
        {
            Log.AllProducts.Remove(_product);
            UpdateProductFile();
        }

        public void UpdateProductFile()
        {
            try
            {
                File.Delete(FileName);
                using (StreamWriter swFisierText = new StreamWriter(FileName, true))
                {
                    foreach (Product p in Log.AllProducts)
                    {
                        swFisierText.WriteLine(p.ConvertToFileString());
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("The file couldn't be open. Error: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Generric Error: " + eGen.Message);
            }
        }

        public void AddCategory(Category c)
        {
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(FileName, true))
                {
                    swFisierText.WriteLine(c.ConvertToFileString());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("The file couldn't be open. Error: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Generric Error: " + eGen.Message);
            }
        }

        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();

            try
            {
                using (StreamReader sr = new StreamReader(FileName))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Category FileCategory = new Category(line);
                        categories.Add(FileCategory);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("The file couldn't be open. Error: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Generric Error: " + eGen.Message);
            }

            return categories;
        }

        public List<Category> FilterCategories(bool filter_name, bool filter_info, string _name, string _info)
        {
            List<Category> filtered = Log.AllCategories;
            if(filter_name)
            {
                filtered = filtered.FindAll(c => c.name.ToLower().Contains(_name.ToLower()));
            }
            if(filter_info)
            {
                filtered = filtered.FindAll(c => c.info.ToLower().Contains(_info.ToLower()));
            }
            return filtered;
        }

        public Category SearchByNameC(string _name)
        {
            return Log.AllCategories.Find(c => c.name.Equals(_name));
        }

        public Category GetCategory(int _number)
        {
            return Log.AllCategories.Find(c => c.number == _number);
        }

        public void DeleteCategory(Category _category)
        {
            Log.AllCategories.Remove(_category);
            UpdateCategoryFile();
        }

        public void UpdateCategory(Category _category)
        {
            for (int i = 0; i < Log.AllCategories.Count; i++)
            {
                if (Log.AllCategories[i] == _category)
                {
                    Log.AllCategories[i] = _category;
                }
            }
            UpdateCategoryFile();
        }

        public void UpdateCategoryFile()
        {
            try
            {
                File.Delete(FileName);
                using (StreamWriter swFisierText = new StreamWriter(FileName, true))
                {
                    foreach (Category c in Log.AllCategories)
                    {
                        swFisierText.WriteLine(c.ConvertToFileString());
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("The file couldn't be open. Error: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Generric Error: " + eGen.Message);
            }
        }

        public void AddTable(Table t)
        {
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(FileName, true))
                {
                    swFisierText.WriteLine(t.ConvertToFileString());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("The file couldn't be open. Error: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Generric Error: " + eGen.Message);
            }
        }

        public List<Table> GetTables()
        {
            List<Table> tables = new List<Table>();

            try
            {
                using (StreamReader sr = new StreamReader(FileName))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Table FileTable = new Table(line);
                        tables.Add(FileTable);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("The file couldn't be open. Error: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Generric Error: " + eGen.Message);
            }

            return tables;
        }

        public List<Table> FilterTables(int _seats, bool _ocupied, bool _reserved, bool status)
        {
            List<Table> filtered = Log.AllTables;
            if (_seats != -1)
            {
                filtered = filtered.FindAll(t => t.seats == _seats);
            }
            if(status)
            {
                filtered = filtered.FindAll(t => (t.occupied == _ocupied && t.reserved == _reserved));
            }
            return filtered;
        }

        public Table GetTable(int _number)
        {
            return Log.AllTables.Find(t => t.number == _number);
        }

        public void DeleteTable(Table _table)
        {
            Log.AllTables.Remove(_table);
            UpdateTableFile();
        }

        public void UpdateTable(Table _table)
        {
            for (int i = 0; i < Log.AllTables.Count; i++)
            {
                if (Log.AllTables[i] == _table)
                {
                    Log.AllTables[i] = _table;
                }
            }
            UpdateTableFile();
        }

        public void UpdateTableFile()
        {
            try
            {
                File.Delete(FileName);
                using (StreamWriter swFisierText = new StreamWriter(FileName, true))
                {
                    foreach (Table t in Log.AllTables)
                    {
                        swFisierText.WriteLine(t.ConvertToFileString());
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("The file couldn't be open. Error: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Generric Error: " + eGen.Message);
            }
        }

        public void AddOrder(Order o)
        {
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(FileName, true))
                {
                    swFisierText.WriteLine(o.ConvertToFileString());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("The file couldn't be open. Error: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Generric Error: " + eGen.Message);
            }
        }

        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();

            try
            {
                using (StreamReader sr = new StreamReader(FileName))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Order FileOrder = new Order(line);
                        orders.Add(FileOrder);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("The file couldn't be open. Error: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Generric Error: " + eGen.Message);
            }

            return orders;
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
            for (int i = 0; i < Log.AllOrders.Count; i++)
            {
                if (Log.AllOrders[i] == _order)
                {
                    Log.AllOrders[i] = _order;
                }
            }
            UpdateOrderFile();
        }

        public void DeleteOrder(Order _order)
        {
            Log.AllOrders.Remove(_order);
            UpdateOrderFile();
        }

        public void UpdateOrderFile()
        {
            try
            {
                File.Delete(FileName);
                using (StreamWriter swFisierText = new StreamWriter(FileName, true))
                {
                    foreach (Order o in Log.AllOrders)
                    {
                        swFisierText.WriteLine(o.ConvertToFileString());
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("The file couldn't be open. Error: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Generric Error: " + eGen.Message);
            }
        }
    }
}
