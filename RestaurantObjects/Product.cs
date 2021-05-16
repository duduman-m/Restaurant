using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;

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

        public int number { set; get; }
        public string name { private set; get; }
        public string info { private set; get; }
        public float price { private set; get; }
        public float weight { private set; get; } //In grams
        public float time_to_prepare { private set; get; } //In minutes

        Category category;

        //Default Constructor
        public Product()
        {
            number = Log.AllProducts.Count + 1;
            name = info = "Undefined";
            price = weight = time_to_prepare = 0;
            category = null;
            Log.AllProducts.Add(this);
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
                throw new Exception("String must contain 6 fields");
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
            number = Log.AllProducts.Count + 1;
            name = ProductAsArrayOfStrings[NAME];
            info = ProductAsArrayOfStrings[INFO];
            price = _price;
            weight = _weight;
            time_to_prepare = _time;
            Category temp = Log.AllCategories.Find(c => c.name.Equals(ProductAsArrayOfStrings[CATEGORY]));
            if(temp != null)
            {
                this.SetCategory(temp);
                temp = null;
            }
            Log.AllProducts.Add(this);
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

        public bool CheckCategory(Category _category)
        {
            if (category.name.Equals(_category.name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetCategoryName()
        {
            return category.name;
        }

        //Compare 2 products
        public string CompareProductPrices(Product _product)
        {
            if(this.price == _product.price)
            {
                return "Products prices are equal.";
            }
            else
            {
                if(this.price < _product.price)
                {
                    return $"{this.name} is cheaper then {_product.name}.";
                }
                else
                {
                    return $"{this.name} is more expensive then {_product.name}.";
                }
            }    

        }

        public void SetFields(string _name, string _info, Category c, float _price, float _weight, float _time)
        {
            name = _name;
            info = _info;
            category = c;
            price = _price;
            weight = _weight;
            time_to_prepare = _time;
        }

        public string ConvertToString()
        {
            return $"Product {name}(#{number}) - {info}\nCategory: {(category != null ? category.name : "Not set")}\nPrice: {price}$\nWeight: {weight} g\nTime to prepare: {time_to_prepare} min\n";
        }

        public string ConvertToFileString()
        {
            return string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}",
                FILE_SEPARATOR, (name ?? " UNDEFINED "), (info ?? " UNDEFINED "), price.ToString(), weight.ToString(), time_to_prepare.ToString(), category.name);
        }

        public string ConvertToListString(int max_name, int max_category_name)
        {
            return $"{number,-10}{name.PadRight(max_name)}{(category != null ? category.name : "").PadRight(max_category_name)}{price,-10}{weight,-10}{time_to_prepare,-20}";
        }
    }
}
