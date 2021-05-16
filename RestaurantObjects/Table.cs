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

        public int number { get; private set; }
        public int seats { get; private set; }
        public bool occupied { get; private set; }
        public bool reserved { get; private set; }

        //Default Constructor
        public Table()
        {
            number = Log.AllTables.Count + 1;
            seats = 0;
            occupied = false;
            reserved = false;
            Log.AllTables.Add(this);
        }

        //Default Constructor with number of seats
        public Table(int _seats)
        {
            number = Log.AllTables.Count + 1;
            seats = _seats;
            occupied = reserved = false;
            Log.AllTables.Add(this);
        }

        /* 
            Constructor using string with information
            Order of information { seats -> occupied -> reserved }
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
            if (!int.TryParse(TableAsArrayOfStrings[SEATS], out _seats))
            {
                throw new ArgumentException("Number of seats is not a number", "seats");
            }
            string[] choices = { "yes", "no" };
            TableAsArrayOfStrings[1] = TableAsArrayOfStrings[OCUPIED].ToLower();
            TableAsArrayOfStrings[2] = TableAsArrayOfStrings[RESERVED].ToLower();
            if (choices.Contains(TableAsArrayOfStrings[OCUPIED]) && choices.Contains(TableAsArrayOfStrings[RESERVED]))
            {
                occupied = TableAsArrayOfStrings[OCUPIED] == "yes" ? true : false;
                reserved = TableAsArrayOfStrings[RESERVED] == "yes" ? true : false;
            }
            else
            {
                throw new ArgumentException("Ocupied and reserved can only be yes/no", "occupied/reserved");
            }
            seats = _seats;
            number = Log.AllTables.Count + 1;
            Log.AllTables.Add(this);
        }

        public void SetFields(int _seats, bool _occupied, bool _reserved)
        {
            seats = _seats;
            occupied = _occupied;
            reserved = _reserved;
        }

        public void DecreaseNumber()
        {
            number--;
        }

        //Set table as occupied
        public void SetAsOcupied()
        {
            occupied = true;
        }

        //Set table as not occupied
        public void SetAsNotOcupied()
        {
            occupied = false;
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
            return $"Table #{number} has {seats} seats, is {(occupied ? "occupied" : "available")}, and is {(reserved ? "reserved" : "not reserved")}.\n";
        }

        public string ConvertToFileString()
        {
            return string.Format("{1}{0}{2}{0}{3}", FILE_SEPARATOR, seats.ToString(), occupied ? "yes": "no", reserved ? "yes": "no");
        }

        public string ConvertToListString()
        {
            return $"{number,-10}{seats,-10}{occupied,-10}{reserved,-10}";
        }
    }
}
