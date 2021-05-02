using System;
using System.Collections.Generic;

namespace RestaurantObjects
{
    public class Category
    {
        // constants
        private const char FILE_SEPARATOR = ';';

        private const int NAME = 0;
        private const int PRODUCTS_NUMBER = 1;
        private const int INFO = 2;

        public static List<Category> AllCategories = new List<Category>();
        int products_number { get; set; } = 0;
        int number { set; get; }
        string name { set; get; }
        string info { set; get; }

        //Default Constructor
        public Category()
        {
            number = AllCategories.Count + 1;
            products_number = 0;
            name = info = "Undefined";
            AllCategories.Add(this);
        }

        /* 
            Constructor using string with information
            Order of information { name -> products_number ->  info}
            Example: "Drinks,This is the drinks category"
        */
        public Category(string CategoryAsString)
        {
            string[] CategoryAsArrayOfStrings = CategoryAsString.Split(new[] { FILE_SEPARATOR }, 3);
            if (CategoryAsArrayOfStrings.Length != 3)
            {
                throw new Exception("String must contain 3 fields");
            }
            number = AllCategories.Count + 1;
            name = CategoryAsArrayOfStrings[NAME];
            if(int.TryParse(CategoryAsArrayOfStrings[PRODUCTS_NUMBER], out int n))
            {
                products_number = n;
            }
            else
            {
                throw new ArgumentException("Number of products is not int type", "products_number");
            }
            info = CategoryAsArrayOfStrings[INFO];
            AllCategories.Add(this);
        }

        //Get name of category
        public string GetName()
        {
            return name;
        }

        public int GetNumber()
        {
            return number;
        }

        //Increase number of products
        public void IncreaseProductsNumber()
        {
            products_number++;
        }

        public string ConvertToString()
        {
            return $"Category {name}(#{number}) - {info}, it has {products_number} products.\n";
        }

        public string ConvertToFileString()
        {
            return string.Format("{1}{0}{2}{0}{3}", FILE_SEPARATOR, (name ?? " UNDEFINED "), products_number.ToString(), (info ?? " UNDEFINED "));
        }
    }
}
