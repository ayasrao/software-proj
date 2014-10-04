using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Keyword_Research
{
    class KeywordSearch
    {
             //Attributes
        string uri;
       
        WebClient client = new WebClient();
        WebClient clients = new WebClient();
        Stream istrm;
        int ch;
        
        string keywords,googleglb;
        string[] keyword_list = new string[500];
        string[] ranks = new string[500];
        // int i;
        string str;
        bool rnksig = false;
        //Constructor
        public KeywordSearch(string googleglb,string keywords)
        {
            this.googleglb = googleglb;
            this.keywords = keywords;
            KeywordSplit(keywords);
        }
        
       private void KeywordSplit(string keywordslist)
        {
            keyword_list = Regex.Split(keywordslist,"\r\n");
        }

        private void GetStream(string url)
        {
            IWebProxy px = new WebProxy("10.1.0.11",8080);
            px.Credentials = new NetworkCredential("test3", "karachi@3");
            client.Proxy = px;
            
            //client.Credentials = new NetworkCredential("test3", "karachi@3");
            
            str = client.DownloadString(url);
        }

        //For printing the html through stream
        public void FindLink(string sitetitle)
        {
            {
                int i;
                int start=0, end;
                string query =sitetitle;
                int mul;
                int j,curloc;
                for (i = 0; i <= keyword_list.Length; i++)
                {
                    for (j = 0; i <= 100; i++)
                    {
                        if(rnksig!=true)
                        {
                        mul = 10 * j;
                        uri = "https://www.google.com/search?q=" + keyword_list[i] +"&start="+ j +"&gl=" + googleglb +"start="+mul.ToString()+ "&ie=utf-8&oe=utf-8&rls=org.mozilla:en-US:official&client=firefox-a&channel=fflb&gws_rd=cr,ssl&ei=c_AaVLLELsasigLZqoH4Bw#rls=org.mozilla:en-US:official&channel=fflb&q=.split%20C%23";
                        GetStream(uri);                       
                        curloc = str.IndexOf(query, start, StringComparison.OrdinalIgnoreCase);
                        if (i != -1)
                         {
                                start = str.IndexOf('"', curloc);
                                start = str.LastIndexOf("onmousedown",curloc);
                                end = str.IndexOf("'", start);
                                uri = str.Substring(start, end - start);
                                start = end;
                          }
                    }
                    else
                    {
                        break;
                    }
                    }

                }
                
            }

        }

    }
}
