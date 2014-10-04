using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Crawler_class4_
{
    public partial class Form1 : Form
    {
        int curloc;
        string[] link;
        int link_no = 0;
        string str;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data ob1 = new Data(textBoxUrl.Text);
            //string datas= null ;
            str=ob1.GetStream();
            curloc = 0;
             //do
            //    {
                    link = ob1.FindLink(str, ref curloc);
                    //if (link != null)
                    //{
                       // datas+= link+"\n";
                    ///}
                 //   else
                   // {
                     //   MessageBox.Show("No link found","Caution");
                       // break;
                    //}
                    
               // } while (link.Length > 0);
                // Close the Response.
                    foreach (string urlss in link)
                    {
                        if (urlss != null)
                        {
                            textBox1.Text = urlss;
                        }
                        else
                        {
                            break;
                        }
                        }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
