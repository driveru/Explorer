﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exprorer_2
{
    class Book
    {
        static string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
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
            string[] month_and_year = date.Split(' ');
            int year = int.Parse(month_and_year[1]);
            int month = Array.IndexOf(months, month_and_year[0]) + 1;
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