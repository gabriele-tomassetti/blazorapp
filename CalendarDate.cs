using System;
using System.Globalization;
using System.Text;

public class CalendarDate
{
    private String stringDate = DateTime.Now.ToString();
    public String StringDate {
        get {
            return stringDate;
        }
        set {
            stringDate = value;
            Date = DateTime.Parse(stringDate);            
        }
    }
    public DateTime Date { get; set; } = DateTime.Now;

    private string GetDateForCalendar(Calendar cal)
    {
        if(Date > cal.MinSupportedDateTime && Date < cal.MaxSupportedDateTime)        
            return $"{cal.GetDayOfMonth(Date):d2}/{cal.GetMonth(Date):d2}/{cal.GetYear(Date):d4}";
        else
            return "Invalid Date";
    }
    public string JulianDate
    {
        get {
            Calendar cal = new JulianCalendar();

            return GetDateForCalendar(cal);                        
        }
    }

    public string HebrewDate
    {
        get {
            Calendar cal = new HebrewCalendar();  
            HebrewCalendar cale = new HebrewCalendar();            
            
            return GetDateForCalendar(cal); 
        }
    }

    public string HijriDate
    {
        get {
            Calendar cal = new HijriCalendar();            
            
            return GetDateForCalendar(cal); 
        }
    }

    public string JapaneseDate
    {
        get {
            Calendar cal = new JapaneseCalendar();            
            
            return GetDateForCalendar(cal); 
        }
    }

    public string KoreanDate
    {
        get {
            Calendar cal = new KoreanCalendar();            
            
            return GetDateForCalendar(cal); 
        }
    }

    public string PersianDate
    {
        get {
            Calendar cal = new PersianCalendar();            
            
            return GetDateForCalendar(cal); 
        }
    }

    public string TaiwanDate
    {
        get {
            Calendar cal = new TaiwanCalendar();            
            
            return GetDateForCalendar(cal); 
        }
    }

    public string ThaiBuddhistDate
    {
        get {
            Calendar cal = new ThaiBuddhistCalendar();            
            
            return GetDateForCalendar(cal); 
        }
    }

    public string ChineseLunisolarDate
    {
        get {
            Calendar cal = new ChineseLunisolarCalendar();            
            
            return GetDateForCalendar(cal); 
        }
    }
}