using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;

namespace Exprorer_2
{
    static class Parcer
    {
        static public List<Book> GetBooksFromThePage(string href, int need_books)
        {
            WebClient wc = new WebClient();
            string page = wc.DownloadString(href);
            Regex ol_rg = new Regex(@"<ol class=.*?products list items product-items.*?>.*?</ol>", RegexOptions.Singleline);
            Match match = ol_rg.Match(page);

            Regex list_regex = new Regex(@"<li .*?</li>", RegexOptions.Singleline);
            var matches = list_regex.Matches(match.Value);

            Regex href_regex = new Regex(@"<a href=.?(?'href'.*?).? class=.*?>");
            Regex name_regex = new Regex(@"<a class=.*?>.?(?'name'.*?)?</a>", RegexOptions.Singleline);
            Regex date_regex = new Regex(@"<div class=.?date-of-publication.?>.?(?'date'.*?)?</div>", RegexOptions.Singleline);
            Regex short_description_regex = new Regex(@"<div class=.?short-description.?>.?(?'short_desc'.*?)?</div>", RegexOptions.Singleline);
            Regex price_regex = new Regex(@"<span class=.?price.?>\$(?'price'.*?)?</span>");

            List<Book> books = new List<Book>();
            foreach (Match mch in matches)
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
