using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyword_Research
{
    public partial class Form1 : Form
    {
        KeywordSearch key;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string site = siteurl.Text;
            key = new KeywordSearch(googlecountry.Text, KeywordsList.Text);
            key.FindLink(site);        
        }
    }
}
