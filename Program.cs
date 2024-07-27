public class Date
{
    private int month;
    private int day;

    // auto-implemented propery year
    public int Year { get; private set; }

    // constructor: use property Month to confirm proper value for month
    // use property Day to confirm proper value for day
    public Date(int theMonth, int theDay, int theYear)
    {
        Month = theMonth; // validate month
        Year = theYear; // could validate year
        Day = theDay;
        Console.WriteLine($"Date object constructor for date {this}");
    } // end constructor

    // property that gets and sets the month
    public int Month
    {
        get
        {
            return month;
        }
        private set
        {
            if (value > 0 && value <= 12) // validate month
                month = value;
            else // month is invalid
                throw new ArgumentOutOfRangeException("Month", value, "Month must be 1-12");
        }
    }

    public int Day
    {
        get
        {
            return day;
        }
        private set
        {
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31, 30 };

            // check if day in range for month
            if (value > 0 && value <= daysPerMonth[Month])
                day = value;

            // check for leap year
            else if (Month == 2 && value == 29 && (Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0)))
                day = value;
            else // day is invalid
                throw new ArgumentOutOfRangeException("Day", value, "Day out of range for current month/year");
        }
    }

    // return a string of the form month/day/year
    public override string ToString()
    {
        return string.Format($"{Month}/{Day}/{Year}");
    }
}