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

        public int number { private set; get; }
        public string client { private set; get; }
        public string info { private set; get; }
        public float price { private set; get; }
        public float time { private set; get; } //In minutes
        public Status status { private set; get; }
        public Discount discount { private set; get; }

        Table table;
        Product[] products;

        //Default Constructor
        public Order()
        {
            number = Log.AllOrders.Count + 1;
            client = info = "Undefined";
            status = 0;
            discount = 0;
            price = time = 0;
            table = null;
            Array.Resize(ref products, 0);
            Log.AllOrders.Add(this);
        }

        /* 
            Constructor using string with information
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
            number = Log.AllOrders.Count + 1;
            client = OrderAsArrayOfStrings[CLIENT];
            info = OrderAsArrayOfStrings[INFO];
            price = time = 0;
            status = (Status)_status;
            discount = (Discount)_discount;
            if (_table != -1)
            {
                table = Log.AllTables.Find(t => t.number == _table);
            }
            else
            {
                table = null;
            }
            int[] products_numbers = Array.ConvertAll(OrderAsArrayOfStrings[PRODUCTS].Split(','), int.Parse);
            Array.Resize(ref products, 0);
            if (products_numbers.Length > 0)
            {
                foreach (Product p in Log.AllProducts)
                {
                    if (products_numbers.Contains(p.number))
                    {
                        this.AddProduct(p);
                    }
                }
            }
            Log.AllOrders.Add(this);
        }

        public void SetFields(string _client, string _info, string _status, string _discount, Table t, string _products)
        {
            client = _client;
            info = _info;
            price = time = 0;
            status = (Status)Enum.Parse(typeof(Status), _status);
            discount = (Discount)Enum.Parse(typeof(Discount), _discount);
            SetTable(t);
            int[] products_numbers = Array.ConvertAll(_products.Split(','), int.Parse);
            Array.Resize(ref products, 0);
            if (products_numbers.Length > 0)
            {
                foreach (Product p in Log.AllProducts)
                {
                    if (products_numbers.Contains(p.number))
                    {
                        this.AddProduct(p);
                    }
                }
            }
        }

        //Set table for order
        public void SetTable(Table _table)
        {
            _table.SetAsOcupied();
            table = _table;
        }

        public bool CheckTable(Table _table)
        {
            return table.number.Equals(_table.number);
        }

        public int GetTableNumber()
        {
            return table.number;
        }

        //Add product to order
        public void AddProduct(Product _product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = _product;
            time += _product.time_to_prepare;
            price += _product.price;
        }

        //Add multiple products to order
        public void AddProduct(Product[] _products)
        {
            int initial = products.Length;
            Array.Resize(ref products, products.Length + _products.Length);
            foreach (Product _product in _products)
            {
                products[initial++] = _product;
                time += _product.time_to_prepare;
                price += _product.price;
            }
        }

        public bool CheckProduct(Product p)
        {
            return products.Count(pr => pr.number.Equals(p.number)) != 0;
        }

        public string ConvertToString()
        {
            string products_list = "Not set";
            if (products != null)
            {
                products_list = string.Join(", ", this.products.Select(r => r.GetShortDescription()));
            }
            return $"Order #{number} placed by {client}\nInformation: {info}\nProducts: {products_list}\nTable: {(table!=null? table.number : -1)}\nPrice: {price - ((float)discount * price / 100)}$ ({price}$ - {discount} Discount:{(int)discount}%)\nTime: {time} min\nStatus: {status}\n";
        }

        public string ConvertToFileString()
        {
            string sProducts = string.Empty;
            if (products != null)
            {
                sProducts = string.Join(",", products.Select(p => p.number));
            }
            return string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}", FILE_SEPARATOR, client, info, price.ToString(), time.ToString(), (int)status, (table != null ? table.number : -1).ToString(), sProducts, (int)discount);
        }

        public string ConvertToListString(int max_client)
        {
            return $"{number,-10}{client.PadRight(max_client)}{table.number,-10}{status,-20}{price,-10}{discount,-20}{time,-20}";
        }
    }
}
