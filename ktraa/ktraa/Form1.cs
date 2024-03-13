namespace ktraa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            string tenDangNhapDung = "admin";
            string matKhauDung = "admin";

            if (tenDangNhap == tenDangNhapDung && matKhau == matKhauDung)
                return true;

            return false;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtUsername.Text;
            string matKhau = txtMatkhau.Text;

            if (KiemTraDangNhap(tenDangNhap, matKhau))
            {
                this.Hide();
                Form2 formDN = new Form2();
                formDN.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
                // Thực hiện các thao tác sau khi đăng nhập thất bại
            }

        }
    }
}