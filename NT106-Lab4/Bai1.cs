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
            string url = urlTextbox.Text;
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Vui lòng nhập URL trang web!");
                return;
            }

            try
            {
                // Gọi hàm getHTML để lấy nội dung HTML và header
                string htmlContent = getHTML(url);

                // Thêm dòng kết thúc trong nội dung HTML
                htmlContent += Environment.NewLine;  // Thêm dòng mới vào cuối nội dung HTML

                // Thay thế các thẻ HTML <br> và <p> thành ký tự xuống dòng
                htmlContent = htmlContent.Replace("<br>", Environment.NewLine);
                htmlContent = htmlContent.Replace("<p>", Environment.NewLine); // Thêm nếu có thẻ <p> để xuống dòng

                // Hiển thị nội dung HTML
                htmlTextbox.Text = htmlContent;

                // Lấy thông tin header
                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                var headers = response.Headers;

                // Cấu hình các cột cho ListView
                headerListview.Columns.Clear(); // Xóa cột cũ nếu có
                headerListview.Columns.Add("STT", 40, HorizontalAlignment.Center); // Cột số thứ tự
                headerListview.Columns.Add("Header", 140, HorizontalAlignment.Left); // Cột header
                headerListview.Columns.Add("Value", 300, HorizontalAlignment.Left); // Cột giá trị

                // Đảm bảo ListView sử dụng chế độ View.Details
                headerListview.View = View.Details;

                // Xóa các dòng cũ trong ListView (nếu có)
                headerListview.Items.Clear();

                // Thêm các header vào ListView
                int stt = 1;
                foreach (string headerKey in headers.AllKeys)
                {
                    string headerValue = headers[headerKey];
                    ListViewItem item = new ListViewItem(stt.ToString()); // Thêm STT
                    item.SubItems.Add(headerKey); // Thêm tên Header
                    item.SubItems.Add(headerValue); // Thêm giá trị Header
                    headerListview.Items.Add(item); // Thêm vào ListView
                    stt++; // Tăng số thứ tự
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        // Hàm lấy nội dung HTML từ URL
        private string getHTML(string szURL)
        {
            string responseFromServer = string.Empty;

            // Tạo WebRequest cho URL
            WebRequest request = WebRequest.Create(szURL);

            // Lấy phản hồi từ server
            WebResponse response = request.GetResponse();

            // Lấy stream chứa nội dung trả về từ server
            Stream dataStream = response.GetResponseStream();

            // Mở stream sử dụng StreamReader để dễ dàng truy cập
            StreamReader reader = new StreamReader(dataStream);

            // Đọc nội dung
            responseFromServer = reader.ReadToEnd();

            // Đóng phản hồi
            response.Close();
            return responseFromServer;
        }
    }
}
