using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Exprorer_2
{
    public class SearchFiles
    {
        //ConcurrentBag<string> paths = new ConcurrentBag<string>();
        Regex search_key;
        object form;
        string source_path;
        bool out_list;
        CancellationTokenSource token;

        public SearchFiles(string source_path, string srch_key, object form, bool out_list, CancellationTokenSource token_src)
        {
            this.source_path = source_path;
            search_key = new Regex(srch_key);
            this.form = form;
            this.out_list = out_list;
            this.token = token_src;
        }

        public void StartSearch()
        {
            bool is_cancelled = SearchFilesFunc(source_path);

            if (is_cancelled)             
                MessageBox.Show("Search was stopped");         
            else
                MessageBox.Show("Search completed");

            if (out_list)
                ((Form1)form).HideLeftCancelSearchButton();
            else
                ((Form1)form).HideRightCancelSearchButton();

            token.Dispose();
            //return paths.ToList();
        }

        bool SearchFilesFunc(string path)
        {
            try
            {
                foreach (string file_name in Directory.GetFiles(path))
                {
                    if (search_key.IsMatch(Path.GetFileName(file_name).ToLower()))
                        ((Form1)form).PrintSearchResults(Path.Combine(path, file_name), out_list);
                    //paths.Add(Path.Combine(path, file_name));
                }

                Parallel.ForEach(Directory.GetDirectories(path), new ParallelOptions { CancellationToken = token.Token }, dir =>
                {
                    if (search_key.IsMatch(Path.GetFileName(dir).ToLower()))
                        ((Form1)form).PrintSearchResults(Path.Combine(path, dir), out_list);
                    //paths.Add(Path.Combine(path, dir));

                    SearchFilesFunc(Path.Combine(path, dir));
                });
                return false;
            }
            catch (UnauthorizedAccessException) { return false; }
            catch (OperationCanceledException) { return true; }
        }
    }
}
