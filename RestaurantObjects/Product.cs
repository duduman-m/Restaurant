using System;
using System.Collections.Generic;

namespace RestaurantObjects
{
    public class Product
    {
        // constants
        private const char FILE_SEPARATOR = ';';

        private const int NAME = 0;
        private const int INFO = 1;
        private const int PRICE = 2;
        private const int WEIGHT = 3;
        private const int TIME = 4;
        private const int CATEGORY = 5;

        public static List<Product> AllProducts = new List<Product>();
        int number { set; get; }
        string name { set; get; }
        string info { set; get; }
        float price { set; get; }
        float weight { set; get; } //In grames
        float time_to_prepare { set; get; } //In minutes

        Category category;

        //Default Constructor
        public Product()
        {
            number = AllProducts.Count + 1;
            name = info = "Undefined";
            price = weight = time_to_prepare = 0;
            category = null;
            AllProducts.Add(this);
        }

        /* 
            Constructor using string with information
            Order of information { name -> info -> price -> weight -> time_to_prepare -> category }
            Example: "Pizza,Fresh italian inspired pizza;25;500;30;Pizza"
        */
        public Product(string ProductAsString)
        {
            string[] ProductAsArrayOfStrings = ProductAsString.Split(FILE_SEPARATOR);
            float _price, _weight, _time;
            if (ProductAsArrayOfStrings.Length != 6)
            {
                throw new Exception("String must contain 5 fields");
            }
            if (!float.TryParse(ProductAsArrayOfStrings[PRICE], out _price))
            {
                throw new ArgumentException("Price is not a number", "price");
            }
            if (!float.TryParse(ProductAsArrayOfStrings[WEIGHT], out _weight))
            {
                throw new ArgumentException("Weight is not a number", "weight");
            }
            if (!float.TryParse(ProductAsArrayOfStrings[TIME], out _time))
            {
                throw new ArgumentException("Time is not a number", "time");
            }
            number = AllProducts.Count + 1;
            name = ProductAsArrayOfStrings[NAME];
            info = ProductAsArrayOfStrings[INFO];
            price = _price;
            weight = _weight;
            time_to_prepare = _time;
            Category temp = Category.AllCategories.Find(c => c.GetName() == ProductAsArrayOfStrings[CATEGORY]);
            if(temp != null)
            {
                this.SetCategory(temp);
                temp = null;
            }
            AllProducts.Add(this);
        }


        //Get number
        public int GetNumber()
        {
            return number;
        }

        public string GetName()
        {
            return name;
        }

        //Get time it takes to prepare product
        public float GetTime()
        {
            return time_to_prepare;
        }

        //Get price
        public float GetPrice()
        {
            return price;
        }

        //Get short description
        public string GetShortDescription()
        {
            return $"{name} - {weight} g";
        }

        //Set category
        public void SetCategory(Category _category)
        {
            _category.IncreaseProductsNumber();
            category = _category;
        }

        public void SetName(string _name)
        {
            name = _name;
        }

        //Compare 2 products
        public string CompareProductPrices(Product _product)
        {
            if(this.GetPrice() == _product.GetPrice())
            {
                return "Products prices are equal.";
            }
            else
            {
                if(this.GetPrice() < _product.GetPrice())
                {
                    return $"{this.name} is cheaper then {_product.name}.";
                }
                else
                {
                    return $"{this.name} is more expensive then {_product.name}.";
                }
            }    

        }

        public string ConvertToString()
        {
            return $"Product {name}(#{number}) - {info}\nCategory: {(category != null ? category.GetName() : "Not set")}\nPrice: {price}$\nWeight: {weight} g\nTime to prepare: {time_to_prepare} min\n";
        }
        public string ConvertToFileString()
        {
            return string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}",
                FILE_SEPARATOR, (name ?? " UNDEFINED "), (info ?? " UNDEFINED "), price.ToString(), weight.ToString(), time_to_prepare.ToString(), category.GetName());
        }
    }
}
