using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Chrome;


namespace Exprorer_2
{
    static class Parcer
    {
        static public List<Book> GetBooksFromThePage(string href, int need_books)
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");

            using (var browser = new ChromeDriver(chromeOptions))
            {
                browser.Navigate().GoToUrl(href);

                Regex block = new Regex(@"<div class=.?card h-100.*>.*", RegexOptions.Singleline);
                Regex footer = new Regex(@".*?(?=<div class=.?text-center.?>)", RegexOptions.Singleline);
                Regex book = new Regex(@"<div class=.?card h-100.*?(?=<div class=.?card-footer bg-transparent.?>)", RegexOptions.Singleline);
                Regex href_regex = new Regex(@"<a .* href=.?(?'href'.*?).? class=.*?>");
                Regex name_regex = new Regex(@"<b>(?'name'.*?)?</b>");
                Regex date_regex = new Regex(@"<p>.?(?'date'.{3} \d{4}?)?</p>");
                Regex short_description_regex = new Regex(@"<p class=.?short_description.?>(?'short_desc'.*?)?</p>", RegexOptions.Singleline);
                Regex price_regex = new Regex(@"<span itemprop(.|\n)*>(\s|\n)*\$(?'price'(.|\n)*?)(\s|\n)*</span>", RegexOptions.Singleline);

                List<Book> books = new List<Book>();
                foreach (Match mch in book.Matches(footer.Match(block.Match(browser.PageSource).Value).Value))
                {
                    if (books.Count < need_books)
                        books.Add(new Book(
                            name_regex.Match(mch.Value).Groups["name"].ToString(),
                            href_regex.Match(mch.Value).Groups["href"].ToString(),
                            short_description_regex.Match(mch.Value).Groups["short_desc"].ToString(),
                            date_regex.Match(mch.Value).Groups["date"].ToString(),
                            price_regex.Match(mch.Value).Groups["price"].ToString()
                            ));
                }
                return books;
            }
        }
    }
}
