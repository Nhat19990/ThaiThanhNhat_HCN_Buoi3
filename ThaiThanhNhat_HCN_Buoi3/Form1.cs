namespace ThaiThanhNhat_HCN_Buoi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            HinhChuNhat hinhChuNhat = new HinhChuNhat();
            hinhChuNhat.setCd(int.Parse(txtchieudai.Text));
            hinhChuNhat.setCr(int.Parse(txtchieurong.Text));

            MessageBox.Show("chiều dài:" + hinhChuNhat.getcd() + "\n chiều rộng" + hinhChuNhat.getCr());
        }

        private void btnsvnhap_Click(object sender, EventArgs e)
        {
            string maSinhVien = txtmsv.Text;
            string tenSinhVien = txttensv.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string lop = txtlop.Text;
            string soDienThoai = txtSoDienThoai.Text;

            // Tạo đối tượng SinhVien
            SinhVien sinhVien = new SinhVien(maSinhVien, tenSinhVien, ngaySinh, lop, soDienThoai);

            // Hiển thị thông tin sinh viên trong TextBox
            MessageBox.Show("Mã Số Sinh Viên:" + maSinhVien + "\n Tên Sinh Viên:" + tenSinhVien +"\n Ngày Sinh:" + ngaySinh + "\n Lớp:" + lop + "\n" +soDienThoai+ "");
           
        }
    }
}
