namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btCheck_Click(object sender, EventArgs e)
        {
            string ipAddress = txtIP.Text; // Lấy địa chỉ IP từ TextBox
            if (string.IsNullOrWhiteSpace(ipAddress))
            {
                txtResult.Text = "Vui lòng nhập địa chỉ IP hợp lệ.";
                return;
            }

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"http://ipinfo.io/{ipAddress}/geo");

            try
            {
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                txtResult.Text = responseBody; // Hiển thị kết quả vào TextBox txtResult
            }
            catch (HttpRequestException ex)
            {
                txtResult.Text = $"Lỗi khi kiểm tra địa chỉ IP: {ex.Message}";
            }
        }
    }
}
