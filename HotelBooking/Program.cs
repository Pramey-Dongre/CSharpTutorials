using System;

namespace HotelBooking
{
    class HotelBookingDetails
    {
        public void Print(HotelBooking hotelBooking)
            {
            Console.WriteLine($" ye this se refer hua hai {hotelBooking.GetDate()}");
            }
    }
    class HotelBooking
    {
        private string _customerName;
        private DateTime _date;
        public HotelBooking(string customerName, DateTime date)
        {
            _customerName = customerName;
            _date = date;
        }
        //public HotelBooking(string customerName):
        //    this(customerName,7)
        //{
        //    Console.WriteLine("mein 1 args wala hoon");
        //}
        public HotelBooking(string customerName, int daysFromNow=7)
        {
            _customerName = customerName;
            _date = DateTime.Now.AddDays(daysFromNow);
            Console.WriteLine("Mein toh 2 args waala hoon");
        }
        public DateTime GetDate() => _date;

        public void OverwriteDate(DateTime date)
        {
            _date = date;
        }
        public void OverwriteMonthAndDay(int month,int day)
        {
            _date = new DateTime(_date.Year, month, day);
            HotelBookingDetails printer = new HotelBookingDetails();
            printer.Print(this);
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
            hotelBooking.OverwriteDate(new DateTime(2031, 5, 12));
            hotelBooking.Display();
            var test = new HotelBooking("boooooyah");
        }
    }
}
