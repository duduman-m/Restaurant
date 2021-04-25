namespace RestaurantObjects
{
    public class Table
    {
        public static int Table_numbers { get; set; } = 0;
        int number { get; set; }
        int seats { get; set; }
        bool ocupied { get; set; }
        bool reserved { get; set; }

        //Default Constructor
        public Table()
        {
            number = ++Table_numbers;
            seats = 0;
            ocupied = false;
            reserved = false;
        }

        //Default Constructor with number of seats
        public Table(int _seats)
        {
            number = ++Table_numbers;
            seats = _seats;
            ocupied = reserved = false;
        }
    }
}
