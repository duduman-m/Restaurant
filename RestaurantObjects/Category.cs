using System;

namespace RestaurantObjects
{
    public class Category
    {
        // constants
        private const char FILE_SEPARATOR = ';';

        private const int NAME = 0;
        private const int PRODUCTS_NUMBER = 1;
        private const int INFO = 2;

        public int products_number { private set; get; } = 0;
        public int number { private set; get; }
        public string name { private set; get; }
        public string info { private set; get; }

        //Default Constructor
        public Category()
        {
            number = Log.AllCategories.Count + 1;
            products_number = 0;
            name = info = "Undefined";
            Log.AllCategories.Add(this);
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
            number = Log.AllCategories.Count + 1;
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
            Log.AllCategories.Add(this);
        }

        //Increase number of products
        public void IncreaseProductsNumber()
        {
            products_number++;
        }

        public void ResetProductsNumber()
        {
            products_number = 0;
        }

        public void SetFields(string _name, string _info)
        {
            name = _name;
            info = _info;
        }

        public string ConvertToString()
        {
            return $"Category {name}(#{number}) - {info}, it has {products_number} products.\n";
        }

        public string ConvertToFileString()
        {
            return string.Format("{1}{0}{2}{0}{3}", FILE_SEPARATOR, (name ?? " UNDEFINED "), products_number.ToString(), (info ?? " UNDEFINED "));
        }

        public string ConvertToListString(int max_name)
        {
            return $"{number,-10}{name.PadRight(max_name)}{products_number,-20}";
        }
    }
}
