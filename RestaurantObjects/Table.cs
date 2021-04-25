using System;
using System.Linq;

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

        /* 
            Constructor using string with information
            Order of information { seats -> ocupied -> reserved }
            Example: "4,no,yes"
        */
        public Table(string TableAsString)
        {
            string[] TableAsArrayOfStrings = TableAsString.Split(',');
            if (TableAsArrayOfStrings.Length != 3)
            {
                throw new ArgumentException("String must contain 3 fields", "number of fields");
            }
            int _seats;
            if (!int.TryParse(TableAsArrayOfStrings[0], out _seats))
            {
                throw new ArgumentException("Number of seats is not a number", "field type");
            }
            string[] choices = { "yes", "no" };
            TableAsArrayOfStrings[1] = TableAsArrayOfStrings[1].ToLower();
            TableAsArrayOfStrings[2] = TableAsArrayOfStrings[2].ToLower();
            if (choices.Contains(TableAsArrayOfStrings[1]) && choices.Contains(TableAsArrayOfStrings[2]))
            {
                ocupied = TableAsArrayOfStrings[1] == "yes" ? true : false;
                reserved = TableAsArrayOfStrings[2] == "yes" ? true : false;
            }
            else
            {
                throw new ArgumentException("Ocupied and reserved can only be yes/no", "field type");
            }
            seats = _seats;
            number = ++Table_numbers;
        }

        public int GetNumber()
        {
            return number;
        }

        //Set table as ocupied
        public void SetAsOcupied()
        {
            ocupied = true;
        }

        //Set table as not ocupied
        public void SetAsNotOcupied()
        {
            ocupied = false;
        }

        //Set table as reserved
        public void SetAsReserved()
        {
            reserved = true;
        }

        //Set table as not reserved
        public void SetAsNotReserved()
        {
            reserved = false;
        }

        public string ConvertToString()
        {
            return $"Table #{number} has {seats} seats, is {(ocupied ? "ocupied" : "available")}, and is {(reserved ? "reserved" : "not reserved")}.\n";
        }
    }
}
