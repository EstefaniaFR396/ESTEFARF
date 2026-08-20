namespace backend;


public class Date
{
    // fields
    private int year;
    private int month;
    private int day;

    // constructor  sin parametros

    public Date()

     {
        year = 1900;
        month = 1;
        day = 1;
    }

    // con paramentros
    public Date(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;
    }
    // properties

    public int Year { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }

    // public methods    
    public override string ToString()
    {
        return $"{year:D4}/{month:D2}/{day:D2}";
    }

    //private methods

    private int  ValidateYear(int year)
    {
        if (year < 0)
        {
            throw new Exception($"the year {year} is not valid."); 
        }
        return year;
    }


}
