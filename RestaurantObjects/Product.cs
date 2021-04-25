using System;

namespace RestaurantObjects
{
    public class Product
    {
        public static int Product_numbers { get; set; } = 0;
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
            number = ++Product_numbers;
            name = info = "Undefined";
            price = weight = time_to_prepare = 0;
            category = null;
        }

        /* 
            Constructor using string with information
            Order of information { name -> info -> price -> weight -> time_to_prepare }
            Example: "Pizza,Fresh italian inspired pizza,25,500,30"
        */
        public Product(string ProductAsString)
        {
            string[] ProductAsArrayOfStrings = ProductAsString.Split(',');
            float _price, _weight, _time;
            if (ProductAsArrayOfStrings.Length != 5)
            {
                throw new ArgumentException("String must contain 5 fields", "number of fields");
            }
            if (!float.TryParse(ProductAsArrayOfStrings[2], out _price))
            {
                throw new ArgumentException("Price is not a number", "field type");
            }
            if (!float.TryParse(ProductAsArrayOfStrings[3], out _weight))
            {
                throw new ArgumentException("Weight is not a number", "field type");
            }
            if (!float.TryParse(ProductAsArrayOfStrings[4], out _time))
            {
                throw new ArgumentException("Time is not a number", "field type");
            }
            number = ++Product_numbers;
            name = ProductAsArrayOfStrings[0];
            info = ProductAsArrayOfStrings[1];
            price = _price;
            weight = _weight;
            time_to_prepare = _time;
            category = null;
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
    }
}
