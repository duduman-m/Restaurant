using System;
using System.Linq;

namespace RestaurantObjects
{
    public class Order
    {
        public static int Order_numbers { get; set; } = 0;
        int number { set; get; }
        string client { set; get; }
        string info { set; get; }
        float price { set; get; }
        float time { set; get; } //In minutes
        string status { get; set; }

        Table table;
        Product[] products;

        //Default Constructor
        public Order()
        {
            number = ++Order_numbers;
            client = info = status = "Undefined";
            price = time = 0;
            table = null;
            Array.Resize(ref products, 0);
        }

        /* 
            Constructor using string with information
            Order of information { client -> info -> status }
            Example: "George,Wants the soda with ice,10,Done"
        */
        public Order(string OrderAsString)
        {
            string[] OrderAsArrayOfStrings = OrderAsString.Split(',');
            if (OrderAsArrayOfStrings.Length != 4)
            {
                throw new ArgumentException("String must contain 5 fields", "number of fields");
            }
            number = ++Order_numbers;
            client = OrderAsArrayOfStrings[0];
            info = OrderAsArrayOfStrings[1];
            price = 0;
            time = 0;
            status = OrderAsArrayOfStrings[2];
            table = null;
            Array.Resize(ref products, 0);
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

        public string ConvertToString()
        {
            string products_list = "Not set";
            if (products != null)
            {
                products_list = string.Join(", ", this.products.Select(r => r.GetShortDescription()));
            }
            return $"Order #{number} placed by {client}\nInformation: {info}\nProducts: {products_list}\nTable: {(table!=null? table.GetNumber() : -1)}\nPrice: {price}$\nTime: {time} min\nStatus: {status}\n";
        }
    }
}
