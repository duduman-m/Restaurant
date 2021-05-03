using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantObjects
{
    public class Order
    {
        // constants
        private const char FILE_SEPARATOR = ';';

        private const int CLIENT = 0;
        private const int INFO = 1;
        private const int PRICE = 2;
        private const int TIME = 3;
        private const int STATUS = 4;
        private const int TABLE = 5;
        private const int PRODUCTS = 6;
        private const int DISCOUNT = 7;

        public static List<Order> AllOrders = new List<Order>();
        int number { set; get; }
        string client { set; get; }
        string info { set; get; }
        float price { set; get; }
        float time { set; get; } //In minutes
        Status status { set; get; }
        Discount discount { set; get; }

        Table table;
        Product[] products;

        //Default Constructor
        public Order()
        {
            number = AllOrders.Count + 1;
            client = info = "Undefined";
            status = 0;
            discount = 0;
            price = time = 0;
            table = null;
            Array.Resize(ref products, 0);
            AllOrders.Add(this);
        }

        /* 
            Constructor using string with information
            Order of information { client -> info -> status }
            Example: "George,Wants the soda with ice,10,Done"
        */
        public Order(string OrderAsString)
        {
            string[] OrderAsArrayOfStrings = OrderAsString.Split(FILE_SEPARATOR);
            if (OrderAsArrayOfStrings.Length != 8)
            {
                throw new Exception("String must contain 8 fields");
            }
            float _price;
            if (!float.TryParse(OrderAsArrayOfStrings[PRICE], out _price))
            {
                throw new ArgumentException("Price is not a number", "price");
            }
            float _time;
            if (!float.TryParse(OrderAsArrayOfStrings[TIME], out _time))
            {
                throw new ArgumentException("Time is not a number", "time");
            }
            int _table;
            if (!int.TryParse(OrderAsArrayOfStrings[TABLE], out _table))
            {
                throw new ArgumentException("Table is not a number", "table");
            }
            int _status;
            int.TryParse(OrderAsArrayOfStrings[STATUS], out _status);
            if(!Enum.IsDefined(typeof(Status), _status))
            {
                throw new ArgumentException("Status is not an available choice", "status");
            }
            int _discount;
            int.TryParse(OrderAsArrayOfStrings[DISCOUNT], out _discount);
            if (!Enum.IsDefined(typeof(Discount), _discount))
            {
                throw new ArgumentException("Discount is not an available choice", "discount");
            }
            number = AllOrders.Count + 1;
            client = OrderAsArrayOfStrings[CLIENT];
            info = OrderAsArrayOfStrings[INFO];
            price = _price;
            time = _time;
            status = (Status)_status;
            discount = (Discount)_discount;
            if (_table != -1)
            {
                table = Table.AllTables.Find(t => t.GetNumber() == _table);
            }
            else
            {
                table = null;
            }
            int[] products_numbers = Array.ConvertAll(OrderAsArrayOfStrings[PRODUCTS].Split(','), int.Parse);
            Array.Resize(ref products, 0);
            if (products_numbers.Length > 0)
            {
                foreach (Product p in Product.AllProducts)
                {
                    if (products_numbers.Contains(p.GetNumber()))
                    {
                        this.AddProduct(p);
                    }
                }
            }
            AllOrders.Add(this);
        }

        //Set table for order
        public void SetTable(Table _table)
        {
            _table.SetAsOcupied();
            table = _table;
        }

        //Add product to order
        public void AddProduct(Product _product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = _product;
            time += _product.GetTime();
            price += _product.GetPrice();
        }

        //Add multiple products to order
        public void AddProduct(Product[] _products)
        {
            int initial = products.Length;
            Array.Resize(ref products, products.Length + _products.Length);
            foreach (Product _product in _products)
            {
                products[initial++] = _product;
                time += _product.GetTime();
                price += _product.GetPrice();
            }
        }

        public string GetClient()
        {
            return client;
        }

        public int GetNumber()
        {
            return number;
        }

        public string ConvertToString()
        {
            string products_list = "Not set";
            if (products != null)
            {
                products_list = string.Join(", ", this.products.Select(r => r.GetShortDescription()));
            }
            return $"Order #{number} placed by {client}\nInformation: {info}\nProducts: {products_list}\nTable: {(table!=null? table.GetNumber() : -1)}\nPrice: {price - ((float)discount * price / 100)}$ ({price}$ - {discount} Discount:{(int)discount}%)\nTime: {time} min\nStatus: {status}\n";
        }

        public string ConvertToFileString()
        {
            string sProducts = string.Empty;
            if (products != null)
            {
                sProducts = string.Join(",", products.Select(p => p.GetNumber()));
            }
            return string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}", FILE_SEPARATOR, client, info, price.ToString(), time.ToString(), (int)status, (table != null ? table.GetNumber() : -1).ToString(), sProducts, (int)discount);
        }
    }
}
