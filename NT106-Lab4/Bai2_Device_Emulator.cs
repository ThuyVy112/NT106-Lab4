using System;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Web.WebView2.WinForms;

namespace NT106_Lab4
{
    public partial class Bai2_Device_Emulator : Form
    {
        public Bai2_Device_Emulator((int Width, int Height) deviceSize, string url, string userAgent)
        {
            InitializeComponent();

            // Thiết lập kích thước giả lập
            this.Size = new System.Drawing.Size(deviceSize.Width, deviceSize.Height);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Tạo WebView2 để hiển thị nội dung
            var webView = new WebView2
            {
                Dock = DockStyle.Fill,
                Source = new Uri(url)
            };

            // Thiết lập User-Agent
            webView.CoreWebView2InitializationCompleted += async (sender, args) =>
            {
                if (webView.CoreWebView2 != null)
                {
                    await webView.CoreWebView2.ExecuteScriptAsync($"navigator.__defineGetter__('userAgent', () => '{userAgent}');");
                }
            };

            // Thêm WebView vào form
            this.Controls.Add(webView);
        }
    }

}
