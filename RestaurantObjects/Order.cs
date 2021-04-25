namespace RestaurantObjects
{
    public class Order
    {
        public static int Order_numbers { get; set; } = 0;
        int number { set; get; }
        string client { set; get; }
        string info { set; get; }
        float price { set; get; }
        float time { set; get; }
        string status { get; set; }

        Table table;
        Product[] products;

        //Default Constructor
        public Order()
        {
            number = ++Order_numbers;
            client = info = status = "Nedefinit";
            price = time = 0;
            table = null;
            products = null;
        }
    }
}
