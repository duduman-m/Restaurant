using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantObjects
{
    public class Table
    {
        // constants
        private const char FILE_SEPARATOR = ';';

        private const int SEATS = 0;
        private const int OCUPIED = 1;
        private const int RESERVED = 2;

        public static List<Table> AllTables = new List<Table>();
        int number { get; set; }
        int seats { get; set; }
        bool ocupied { get; set; }
        bool reserved { get; set; }

        //Default Constructor
        public Table()
        {
            number = AllTables.Count + 1;
            seats = 0;
            ocupied = false;
            reserved = false;
            AllTables.Add(this);
        }

        //Default Constructor with number of seats
        public Table(int _seats)
        {
            number = AllTables.Count + 1;
            seats = _seats;
            ocupied = reserved = false;
            AllTables.Add(this);
        }

        /* 
            Constructor using string with information
            Order of information { seats -> ocupied -> reserved }
            Example: "4;yes;no"
        */
        public Table(string TableAsString)
        {
            string[] TableAsArrayOfStrings = TableAsString.Split(FILE_SEPARATOR);
            if (TableAsArrayOfStrings.Length != 3)
            {
                throw new Exception("String must contain 3 fields");
            }
            int _seats;
            if (!int.TryParse(TableAsArrayOfStrings[0], out _seats))
            {
                throw new ArgumentException("Number of seats is not a number", "seats");
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
                throw new ArgumentException("Ocupied and reserved can only be yes/no", "ocupied/reserved");
            }
            seats = _seats;
            number = AllTables.Count + 1;
            AllTables.Add(this);
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

        public string ConvertToFileString()
        {
            return string.Format("{1}{0}{2}{0}{3}", FILE_SEPARATOR, seats.ToString(), ocupied ? "yes": "no", reserved ? "yes": "no");
        }
    }
}
