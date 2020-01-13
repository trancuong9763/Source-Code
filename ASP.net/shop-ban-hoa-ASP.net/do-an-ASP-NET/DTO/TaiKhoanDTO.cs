using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class TaiKhoanDTO
    {
        private string tenTaiKhoan;

        public string TenTaiKhoan
        {
            get { return tenTaiKhoan; }
            set { tenTaiKhoan = value; }
        }
        private string matKhau;

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string soDienThoai;

        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }
        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        private bool laAdmin;

        public bool LaAdmin
        {
            get { return laAdmin; }
            set { laAdmin = value; }
        }
        private bool trangThai;

        public bool TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public TaiKhoanDTO()
        {
            TrangThai = true;
            LaAdmin = false;

        }
       
    }
}
