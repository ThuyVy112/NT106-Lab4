using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace NT106_Lab4
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private async void dowloadBtn_Click(object sender, EventArgs e)
        {
            string url = urlTextbox.Text.Trim();

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Vui lòng nhập URL trang web!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Giả mạo thông tin User-Agent
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (Stream dataStream = response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(dataStream))
                    {
                        string htmlContent = reader.ReadToEnd();
                        htmlTextbox.Text = htmlContent.Replace("<br>", Environment.NewLine).Replace("<p>", Environment.NewLine);
                    }

                    headerListview.Columns.Clear();
                    headerListview.Columns.Add("STT", 40, HorizontalAlignment.Center);
                    headerListview.Columns.Add("Header", 140, HorizontalAlignment.Left);
                    headerListview.Columns.Add("Value", 300, HorizontalAlignment.Left);
                    headerListview.View = View.Details;
                    headerListview.Items.Clear();

                    int stt = 1;
                    foreach (string headerKey in response.Headers.AllKeys)
                    {
                        ListViewItem item = new ListViewItem(stt.ToString());
                        item.SubItems.Add(headerKey);
                        item.SubItems.Add(response.Headers[headerKey]);
                        headerListview.Items.Add(item);
                        stt++;
                    }
                }
            }
            catch (WebException webEx)
            {
                if (webEx.Response is HttpWebResponse errorResponse)
                {
                    MessageBox.Show($"Lỗi HTTP {errorResponse.StatusCode}: {errorResponse.StatusDescription}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Lỗi mạng: {webEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (UriFormatException)
            {
                MessageBox.Show("URL không hợp lệ. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}