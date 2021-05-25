using System;

namespace RestaurantObjects
{
    public class Feedback
    {

        // constants
        private const char FILE_SEPARATOR = ';';

        private const int DATE = 0;
        private const int FROM = 1;
        private const int MESSAGE = 2;
        private const int RATING = 3;

        public DateTime date { private set; get; }
        public string from { private set; get; }
        public string message { private set; get; }
        public Rating rating { private set; get; }

        public Feedback(DateTime _date, string _from, string _message, int _rating)
        {
            date = _date;
            from = _from;
            message = _message;
            rating = (Rating) _rating;
        }

        public Feedback(string FeedbackAsString)
        {
            string[] FeedbackAsArrayOfStrings = FeedbackAsString.Split(FILE_SEPARATOR);
            date = DateTime.Parse(FeedbackAsArrayOfStrings[DATE]);
            from = FeedbackAsArrayOfStrings[FROM];
            message = FeedbackAsArrayOfStrings[MESSAGE];
            rating = (Rating) int.Parse(FeedbackAsArrayOfStrings[RATING]);
        }

        public string ConvertToFileString()
        {
            return string.Format("{1}{0}{2}{0}{3}{0}{4}", FILE_SEPARATOR, date, from, message, (int)rating);
        }
    }
}
