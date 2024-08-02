using System;

namespace HotelBooking
{
    class HotelBooking
    {
        private string _customerName;
        private DateTime _date;
        public HotelBooking(string customerName, DateTime date)
        {
            _customerName = customerName;
            _date = date;
        }
        public HotelBooking(string customerName):
            this(customerName,7)
        {
            Console.WriteLine("mein 1 args wala hoon");
        }
        public HotelBooking(string customerName, int daysFromNow)
        {
            _customerName = customerName;
            _date = DateTime.Now.AddDays(daysFromNow);
            Console.WriteLine("Mein toh 2 args waala hoon");
        }

        public void OverwriteDate(DateTime date)
        {
            _date = date;
        }
        public void OverwriteMonthAndDay(int month,int day)
        {
            _date = new DateTime(_date.Year, month, day);
        }
        public void Display()
        {
            Console.WriteLine($"{_customerName} has been scheduled for dining at {_date.Day}/{_date.Month}/{_date.Year} which is {_date.DayOfWeek}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var hotelBooking = new HotelBooking("Grayson", new DateTime(2017, 8, 11));
            hotelBooking.Display();
            hotelBooking.OverwriteMonthAndDay(5, 20);
            hotelBooking.Display();
            hotelBooking.OverwriteDate(new DateTime(2031, 5, 12));
            hotelBooking.Display();
            var test = new HotelBooking("boooooyah",15);
        }
    }
}
