using System;
using System.Collections.Generic;
using System.Text;

namespace Exprorer_2
{
    class Book
    {
        static string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
        static string[] short_months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        public string label { get; private set; }
        public string short_description { get; private set; }
        public string href { get; private set; }
        public DateTime date { get; private set; }
        public double price { get; private set; }
        public Book(string label, string href, string short_desc, string date, string price)
        {
            this.label = label;
            this.href = href;
            this.short_description = short_desc;
            string[] month_and_year = date.Split();
            while (month_and_year[0] == "")
            {
                for (int i = 1; i < month_and_year.Length; i++)
                    month_and_year[i - 1] = month_and_year[i];
            }
            int year = int.Parse(month_and_year[1]);
            int month = Array.IndexOf(short_months, month_and_year[0]) + 1;
            this.date = new DateTime(year, month, 1);
            this.price = double.Parse(price.Replace('.', ','));
        }
        public Book() { }
        public override string ToString()
        {
            return $"{label} was written at {months[date.Month-1]} {date.Year} with a price ${price}";
        }
    }
}
