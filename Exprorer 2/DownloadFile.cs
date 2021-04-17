using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Threading;

namespace Exprorer_2
{
    class DownloadFile
    {
        private string remote_path;
        private string local_path;
        private object form;
        CancellationTokenSource cancellationTokenSource;

        public DownloadFile(string file_source, string dest_path, object form, CancellationTokenSource dwnld_cnclltn_src)
        {
            remote_path = file_source;
            local_path = dest_path;
            this.form = form;
            cancellationTokenSource = dwnld_cnclltn_src;
        }
        public void StartDownload()
        {
            // Function will return the number of bytes processed
            // to the caller. Initialize to 0 here.
            int bytesProcessed = 0;

            // Assign values to these objects here so that they can
            // be referenced in the finally block
            Stream remoteStream = null;
            Stream localStream = null;
            WebResponse response = null;

            // Use a try/catch/finally block as both the WebRequest and Stream
            // classes throw exceptions upon error
            try
            {
                // Create a request for the specified remote file name
                WebRequest request = WebRequest.Create(remote_path);
                if (request != null)
                {
                    // Send the request to the server and retrieve the
                    // WebResponse object 
                    response = request.GetResponse();
                    if (response != null)
                    {
                        // Once the WebResponse object has been retrieved,
                        // get the stream object associated with the response's data
                        remoteStream = response.GetResponseStream();

                        // Create the local file
                        localStream = File.Create(Path.Combine(local_path, Path.GetFileName(remote_path)));

                        // Allocate a 1k buffer
                        byte[] buffer = new byte[1024];
                        int bytesRead;

                        // Simple do/while loop to read from stream until
                        // no bytes are returned
                        do
                        {
                            if (cancellationTokenSource.IsCancellationRequested)
                                throw new OperationCanceledException();

                            // Read data (up to 1k) from the stream
                            bytesRead = remoteStream.Read(buffer, 0, buffer.Length);

                            // Write the data to the local file
                            localStream.Write(buffer, 0, bytesRead);

                            // Increment total bytes processed
                            bytesProcessed += bytesRead;
                        } while (bytesRead > 0);

                        MessageBox.Show("Download completed !");
                    }
                }
            }
            catch (OperationCanceledException)
            {
                localStream.Close();
                File.Delete(Path.Combine(local_path, Path.GetFileName(remote_path)));
                MessageBox.Show("Download cancelled");
                ((Form1)form).HideDownloadCancelButton();
            }
            catch (Exception e)
            {
                File.Delete(Path.Combine(local_path, Path.GetFileName(remote_path)));
                MessageBox.Show($"Download error {e.Message}");
            }
            finally
            {
                // Close the response and streams objects here 
                // to make sure they're closed even if an exception
                // is thrown at some point
                if (response != null) response.Close();
                if (remoteStream != null) remoteStream.Close();
                if (localStream != null) localStream.Close();
            }
            
        }
    }
}
