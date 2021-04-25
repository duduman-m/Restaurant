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
            name = info = "Nedefinit";
        }
    }
}
