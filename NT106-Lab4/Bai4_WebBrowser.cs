using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace NT106_Lab4
{
    public partial class Bai4_WebBrowser : Form
    {
        private WebView2 webView;
        public Bai4_WebBrowser()
        {
            InitializeComponent();
            InitializeComponent();
            webView = new WebView2
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(webView);
        }

        // Constructor nhận URL
        public Bai4_WebBrowser(string url) : this()
        {
            webView.Source = new Uri(url);
        }
    }
}
  
