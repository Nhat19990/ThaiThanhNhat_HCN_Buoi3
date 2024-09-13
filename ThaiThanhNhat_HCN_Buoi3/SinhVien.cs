using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiThanhNhat_HCN_Buoi3
{
    internal class SinhVien
    {
        public string MaSinhVien { get; set; }
        public string TenSinhVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Lop { get; set; }
        public string SoDienThoai { get; set; }

        public SinhVien(string maSinhVien, string tenSinhVien, DateTime ngaySinh, string lop, string soDienThoai)
        {
            MaSinhVien = maSinhVien;
            TenSinhVien = tenSinhVien;
            NgaySinh = ngaySinh;
            Lop = lop;
            SoDienThoai = soDienThoai;
        }

        public override string ToString()
        {
            return $"Mã Sinh Viên: {MaSinhVien}\nTên: {TenSinhVien}\nNgày Sinh: {NgaySinh.ToShortDateString()}\nLớp: {Lop} Điện Thoại: {SoDienThoai}" ;
        }
    }
}
