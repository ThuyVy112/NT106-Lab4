using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace NT106_Lab4
{
    public partial class Bai3 : Form
    {
        private static HttpClient client = new()
        {
            BaseAddress = new Uri("https://jsonplaceholder.typicode.com")
        };
        public Bai3()
        {
            InitializeComponent();
        }

        private async void fetchPhotos_Click(object sender, EventArgs e)
        {
            string url = client.BaseAddress + "/photos";
            try
            {
                // gửi request lấy dữ liệu
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Throw exception nếu không thành công

                // Đọc dữ liệu JSON
                string responseData = await response.Content.ReadAsStringAsync();
                List<Photos> photos = JsonConvert.DeserializeObject<List<Photos>>(responseData);

                // Xóa các cột cũ trong ListView (nếu có)
                listView.Columns.Clear();

                // Cấu hình các cột cho ListView
                listView.Columns.Add("albumId", 100, HorizontalAlignment.Center);
                listView.Columns.Add("id", 50, HorizontalAlignment.Left);
                listView.Columns.Add("title", 300, HorizontalAlignment.Left);
                listView.Columns.Add("url", 300, HorizontalAlignment.Left);
                listView.Columns.Add("thumbnailUrl", 300, HorizontalAlignment.Left);

                listView.View = View.Details;
                // xóa dòng cũ trong ListView (nếu có)
                listView.Items.Clear();

                // hiển thị dữ liệu 100 photo đầu tiên
                foreach (var photo in photos.GetRange(0, 100))
                {
                    ListViewItem item = new(photo.albumId.ToString());
                    item.SubItems.Add(photo.id.ToString());
                    item.SubItems.Add(photo.title);
                    item.SubItems.Add(photo.url);
                    item.SubItems.Add(photo.thumbnailUrl);
                    listView.Items.Add(item);
                }


            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void fetchComments_Click(object sender, EventArgs e)
        {
            string url = client.BaseAddress + "/comments";
            try
            {
                // gửi request lấy dữ liệu
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Throw exception nếu không thành công

                // Đọc dữ liệu JSON
                string responseData = await response.Content.ReadAsStringAsync();
                List<Comments> comments = JsonConvert.DeserializeObject<List<Comments>>(responseData);

                // Xóa các cột cũ trong ListView (nếu có)
                listView.Columns.Clear();

                // Cấu hình các cột cho ListView
                listView.Columns.Add("postId", 50, HorizontalAlignment.Center);
                listView.Columns.Add("id", 50, HorizontalAlignment.Left);
                listView.Columns.Add("name", 300, HorizontalAlignment.Left);
                listView.Columns.Add("email", 200, HorizontalAlignment.Left);
                listView.Columns.Add("body", 450, HorizontalAlignment.Left);

                listView.View = View.Details;
                // xóa dòng cũ trong ListView (nếu có)
                listView.Items.Clear();

                // hiển thị dữ liệu 100 photo đầu tiên
                foreach (var comment in comments.GetRange(0, 100))
                {
                    ListViewItem item = new(comment.postId.ToString());
                    item.SubItems.Add(comment.id.ToString());
                    item.SubItems.Add(comment.name);
                    item.SubItems.Add(comment.email);
                    item.SubItems.Add(comment.body);
                    listView.Items.Add(item);
                }

            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void fetchUsers_Click(object sender, EventArgs e)
        {
            string url = client.BaseAddress + "/users";
            try
            {
                // gửi request lấy dữ liệu
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Throw exception nếu không thành công

                // Đọc dữ liệu JSON
                string responseData = await response.Content.ReadAsStringAsync();
                List<Users> users = JsonConvert.DeserializeObject<List<Users>>(responseData);

                // Xóa các cột cũ trong ListView (nếu có)
                listView.Columns.Clear();

                // Cấu hình các cột cho ListView
                listView.Columns.Add("id", 50, HorizontalAlignment.Center);
                listView.Columns.Add("name", 100, HorizontalAlignment.Left);
                listView.Columns.Add("username", 100, HorizontalAlignment.Left);
                listView.Columns.Add("email", 200, HorizontalAlignment.Left);
                listView.Columns.Add("phone", 250, HorizontalAlignment.Left);
                listView.Columns.Add("website", 200, HorizontalAlignment.Left);

                listView.View = View.Details;
                // xóa dòng cũ trong ListView (nếu có)
                listView.Items.Clear();

                // hiển thị dữ liệu 100 photo đầu tiên
                foreach (var user in users.GetRange(0, 10))
                {
                    ListViewItem item = new(user.id.ToString());
                    item.SubItems.Add(user.name.ToString());
                    item.SubItems.Add(user.username);
                    item.SubItems.Add(user.email);
                    item.SubItems.Add(user.phone);
                    item.SubItems.Add(user.website);
                    listView.Items.Add(item);
                }

            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class Photos
    {
        public int albumId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }
    }

    public class Comments
    {
        public int postId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }
    }

    public class Users
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
    }
}
