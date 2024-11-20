using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106_Lab4
{
    public partial class Bai2 : Form
    {
        string url;
        public Bai2()
        {
            InitializeComponent();

            // khởi tạo comboBox user agent
            userAgentComboBox.Items.Add("Safari - iPhone iOS 13.2");
            userAgentComboBox.Items.Add("Safari - iPad iOS 13.2");
            userAgentComboBox.Items.Add("Chrome - Windows");
            userAgentComboBox.SelectedIndex = 0; // Chọn mặc định
        }

        private string getHTML(string szURL, string userAgent)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(szURL);
            request.UserAgent = userAgent;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream dataStream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(dataStream))
            {
                return reader.ReadToEnd();
            }
        }

        private (int Width, int Height) GetDeviceSize(string userAgent)
        {
            if (userAgent == "Mozilla/5.0 (iPhone; CPU iPhone OS 13_2_3 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/13.0.3 Mobile/15E148 Safari/604.1")
                return (375, 667); //màn hình iphone
            else if (userAgent == "Mozilla/5.0 (iPad; CPU iPhone OS 13_2_3 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/13.0.3 Mobile/15E148 Safari/604.1")
                return (768, 1024); // màn hình ipad
            else if (userAgent == "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/131.0.0.0 Safari/537.36")
                return (1366, 768); //màn hình laptop
            else
                return (800, 600); // mặc định
        }


        private void loadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy URL từ textBox
                url = urlTextBox.Text;
                if (string.IsNullOrEmpty(url))
                {
                    MessageBox.Show("Vui lòng nhập URL trang web!");
                    return;
                }

                // Lấy user agent từ comboBox
                string userAgent = "";
                string selectedUserAgent = userAgentComboBox.SelectedItem.ToString();
                if (selectedUserAgent == "Safari - iPhone iOS 13.2")
                {
                    userAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 13_2_3 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/13.0.3 Mobile/15E148 Safari/604.1";
                }
                else if (selectedUserAgent == "Safari - iPad iOS 13.2")
                {
                    userAgent = "Mozilla/5.0 (iPad; CPU iPhone OS 13_2_3 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/13.0.3 Mobile/15E148 Safari/604.1";
                }
                else if (selectedUserAgent == "Chrome - Windows")
                {
                    userAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/131.0.0.0 Safari/537.36";
                }

                // Lấy mã nguồn html và hiện lên text box
                string htmlContent = getHTML(url,userAgent);
                richTextBox1.Text = htmlContent;

                // Tạo form mới để hiển thị nội dung HTML
                Bai2_Device_Emulator emulator = new Bai2_Device_Emulator(GetDeviceSize(userAgent), url, htmlContent);
                emulator.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
