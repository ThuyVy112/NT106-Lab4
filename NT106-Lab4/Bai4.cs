using Microsoft.Web.WebView2.WinForms;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106_Lab4
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private async void loadBtn_Click(object sender, EventArgs e)
        {
            string url = urlTxb.Text; // txtUrl là TextBox nhập URL
            if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                Bai4_WebBrowser formWebView = new Bai4_WebBrowser(url);
                formWebView.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập URL hợp lệ.");
            }
        }

        private async void downloadBtn_Click(object sender, EventArgs e)
        {
            string url = urlTxb.Text;
            if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var response = await client.GetStringAsync(url);
                        SaveFileDialog saveFileDialog = new SaveFileDialog
                        {
                            Filter = "HTML File|*.html"
                        };

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            System.IO.File.WriteAllText(saveFileDialog.FileName, response);
                            MessageBox.Show("Mã nguồn đã được lưu thành công.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập URL hợp lệ.");
            }
        }

        private async void sourceBtn_Click(object sender, EventArgs e)
        {
            string url = urlTxb.Text; 
            if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var response = await client.GetStringAsync(url);
                        sourceRtb.Text = response; 
                        sourceRtb.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập URL hợp lệ.");
            }
        }
    }
}