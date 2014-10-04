using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace Crawler_class4_
{
    class Data
    {
                //Attributes
        string uri;
        HttpWebRequest req;
        HttpWebResponse resp;
        Stream istrm;
        int ch;
        string htmlCode = "";
        int curloc;
        int count_data_url = 0;
        string str;
        string[] data_urls=null;// = new string[2000];
        //webclient
        WebClient client = new WebClient();
        //Constructor
        public Data(string uri)
        {
            this.uri = uri;
        }

        public string GetStream()
        {
          /*  req = (HttpWebRequest)HttpWebRequest.Create(uri);
            uri = null;
            resp = (HttpWebResponse)req.GetResponse();
            istrm = resp.GetResponseStream();
            StreamReader rdr = new StreamReader(istrm);
            str = rdr.ReadToEnd();
            resp.Close();
            curloc = 0;*/
            IWebProxy px = new WebProxy("10.1.0.11", 8080);
            px.Credentials = new NetworkCredential("test3", "karachi@3");
            client.Proxy = px;

            //client.Credentials = new NetworkCredential("test3", "karachi@3");

            str = client.DownloadString(uri);
            return str;
        }

        //For printing the html through stream
        public string[] FindLink(string htmlstr, ref int startloc)
        {
                
                int i,ind;
                int start, end;
                string query = "href=\"http";
                
               // for (int k = 0; k <= htmlstr.Length;k++ )
                //{

                do
                {
                    i = htmlstr.IndexOf(query, startloc, StringComparison.OrdinalIgnoreCase);
                    ind = i;
                    start = htmlstr.IndexOf('"', i) + 1;
                    end = htmlstr.IndexOf('"', start);
                    data_urls[count_data_url] = htmlstr.Substring(start, end - start);
                    count_data_url++;
                    i = end;
                    
                } while (i != -1);   
               // } //
                
            return data_urls;

        }

    }
}
