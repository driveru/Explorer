using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;


namespace Exprorer_2
{
    public class SearchFiles
    {
        //ConcurrentBag<string> paths = new ConcurrentBag<string>();
        Regex search_key;
        object form;
        string source_path;
        bool out_list;

        public SearchFiles(string source_path, string srch_key, object form, bool out_list)
        {
            this.source_path = source_path;
            search_key = new Regex(srch_key);
            this.form = form;
            this.out_list = out_list;
        }

        public void StartSearch()
        {
            SearchFilesFunc(source_path);
            //return paths.ToList();
        }

        void SearchFilesFunc(string path)
        {
            //Thread.Sleep(new Random().Next(0, 1000));
            //Console.WriteLine($"Checking {path}");
            try
            {
                foreach (string file_name in Directory.GetFiles(path))
                {
                    if (search_key.IsMatch(Path.GetFileName(file_name).ToLower()))
                        ((Form1)form).PrintSearchResults(Path.Combine(path, file_name), out_list);
                        //paths.Add(Path.Combine(path, file_name));
                }

                Parallel.ForEach(Directory.GetDirectories(path), dir =>
                {
                    if (search_key.IsMatch(Path.GetFileName(dir).ToLower()))
                        ((Form1)form).PrintSearchResults(Path.Combine(path, dir), out_list);
                        //paths.Add(Path.Combine(path, dir));

                    SearchFilesFunc(Path.Combine(path, dir));
                });
            }
            catch (UnauthorizedAccessException) { }
        }
    }
}
