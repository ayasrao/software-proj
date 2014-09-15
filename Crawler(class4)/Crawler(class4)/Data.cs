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
        string str;
        //Constructor
        public Data(string uri)
        {
            this.uri = uri;
        }

        public string GetStream()
        {
            req = (HttpWebRequest)HttpWebRequest.Create(uri);
            uri = null;
            resp = (HttpWebResponse)req.GetResponse();
            istrm = resp.GetResponseStream();
            StreamReader rdr = new StreamReader(istrm);
            str = rdr.ReadToEnd();
            resp.Close();
            curloc = 0;
            return str;
        }

        //For printing the html through stream
        public string FindLink(string htmlstr, ref int startloc)
        {
            {
                int i;
                int start, end;
                string query = "href=\"http";
                i = htmlstr.IndexOf(query, startloc, StringComparison.OrdinalIgnoreCase);
                if (i != -1)
                {
                    start = htmlstr.IndexOf('"', i) + 1;
                    end = htmlstr.IndexOf('"', start);
                    uri = htmlstr.Substring(start, end - start);
                    startloc = end;
                }
                return uri;
            }

        }

    }
}
