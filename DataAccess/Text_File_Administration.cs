using RestaurantObjects;
using System;
using System.Collections.Generic;
using System.IO;

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
            for (int i = 0; i < Product.AllProducts.Count; i++)
            {
                if (Product.AllProducts[i] == _product)
                {
                    Product.AllProducts[i] = _product;
                }
            }
            UpdateProductFile();
        }

        public void UpdateProductFile()
        {
            try
            {
                File.Delete(FileName);
                using (StreamWriter swFisierText = new StreamWriter(FileName, true))
                {
                    foreach (Product p in Product.AllProducts)
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
            for (int i = 0; i < Category.AllCategories.Count; i++)
            {
                if (Category.AllCategories[i] == _category)
                {
                    Category.AllCategories[i] = _category;
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
                    foreach (Category c in Category.AllCategories)
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

        public Table SearchByNumberT(int _number)
        {
            return Table.AllTables.Find(t => t.GetNumber() == _number);
        }

        public void UpdateTable(Table _table)
        {
            for (int i = 0; i < Table.AllTables.Count; i++)
            {
                if (Table.AllTables[i] == _table)
                {
                    Table.AllTables[i] = _table;
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
                    foreach (Table t in Table.AllTables)
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
            for (int i = 0; i < Order.AllOrders.Count; i++)
            {
                if (Order.AllOrders[i] == _order)
                {
                    Order.AllOrders[i] = _order;
                }
            }
            UpdateOrderFile();
        }

        public void UpdateOrderFile()
        {
            try
            {
                File.Delete(FileName);
                using (StreamWriter swFisierText = new StreamWriter(FileName, true))
                {
                    foreach (Order o in Order.AllOrders)
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
