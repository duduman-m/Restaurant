namespace RestaurantObjects
{
    public enum Status
    {
        On_Hold = 0,
        In_Progress = 1,
        Done = 2
    }

    public enum Discount
    {
        // In procents
        None = 0,
        Loyal_Customer = 25,
        Employee = 50,
        Special_Ocassion = 100
    }

    public enum Rating
    {
        one_star = 1,
        two_star = 2,
        three_star = 3,
        four_star = 4,
        five_star = 5
    }
}
