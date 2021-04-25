namespace RestaurantObjects
{
    public class Product
    {
        public static int Product_numbers { get; set; } = 0;
        int number { set; get; }
        string name { set; get; }
        string info { set; get; }
        float price { set; get; }
        float weight { set; get; }
        float time_to_prepare { set; get; }

        Category category;

        //Default Constructor
        public Product()
        {
            number = ++Product_numbers;
            name = info = "Nedefinit";
            price = weight = time_to_prepare = 0;
            category = null;
        }
    }
}
