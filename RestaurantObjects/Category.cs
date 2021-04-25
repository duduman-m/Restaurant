using System;

namespace RestaurantObjects
{
    public class Category
    {
        public static int Category_numbers { get; set; } = 0;
        int products_number { get; set; } = 0;
        int number { set; get; }
        string name { set; get; }
        string info { set; get; }

        //Default Constructor
        public Category()
        {
            number = ++Category_numbers;
            products_number = 0;
            name = info = "Undefined";
        }

        /* 
            Constructor using string with information
            Order of information { name -> info }
            Example: "Drinks,This is the drinks category"
        */
        public Category(string CategoryAsString)
        {
            string[] CategoryAsArrayOfStrings = CategoryAsString.Split(new[] { ',' }, 2);
            if (CategoryAsArrayOfStrings.Length != 2)
            {
                throw new ArgumentException("String must contain 2 fields", "number of fields");
            }
            number = ++Category_numbers;
            name = CategoryAsArrayOfStrings[0];
            info = CategoryAsArrayOfStrings[1];
            products_number = 0;
        }

        //Get name of category
        public string GetName()
        {
            return name;
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
    }
}
