using System;
using System.Collections.Generic;
using QuanLySInhVien.entity;
using QuanLySInhVien.model;

namespace QuanLySInhVien.controller
{
    public class SinhVienController
    {
              private SInhVienModel _sinhVienModel = new SInhVienModel();
        public void TaoMoiSinhVien()
        {
            Console.WriteLine("Vui lòng nhập thông tin sinh viên: ");
            var sinhVien = new SInhVien();
            Console.WriteLine("Nhập mã sinh viên: ");
            var maSinhVien =  Console.ReadLine();
            sinhVien.Ma = maSinhVien;
            Console.WriteLine("Nhập họ sinh viên: ");
            var ho =  Console.ReadLine();
            sinhVien.Ho = ho;
            Console.WriteLine("Nhập tên sinh viên: ");
            var ten =  Console.ReadLine();
            sinhVien.Ten = ten;
            Console.WriteLine("Nhập tuổi sinh viên: ");
            var tuoi =  Console.ReadLine();
            sinhVien.Tuoi = Convert.ToInt32(tuoi);
            Console.WriteLine("Nhập trạng thái sinh viên: ");
            var trangThai =  Console.ReadLine();
            sinhVien.TrangThai = Convert.ToInt32(trangThai);
            bool result =  _sinhVienModel.Save(sinhVien);
            if (result)
            {
                Console.WriteLine("Tao moi sinh vien thanh cong.");
            }
            else
            {
                Console.WriteLine("Tao moi sinh vien that bai.");
            }
        }

        public void HienThiDanhSachSinhVien()
        {
            Console.WriteLine("Danh sách sinh viên vừa nhập là: ");
            List<SInhVien> listSinhVien = _sinhVienModel.FindAll();
            for (var i = 0; i < listSinhVien.Count; i++)
            {
                var sv1 = listSinhVien[i];
                Console.WriteLine($"Mã: {sv1.Ma}, Họ và tên: {sv1.Ho} {sv1.Ten}, Tuổi: {sv1.Tuoi}, Trạng thái: {sv1.TrangThai}");
            }

            if (_sinhVienModel == null)
            {
                Console.WriteLine("danh sach sinh vien cua ban dang rong vui long nhap thong tin sinh vien");
                
            }
        }
        
        public void SuaThongTinSinhVien()
        {
            Console.WriteLine("Vui lòng nhập mã sinh viên cần sửa: ");
            var maSinhVien = Console.ReadLine();
            SInhVien sv = _sinhVienModel.FindById(maSinhVien);
            if (sv == null)
            {
                Console.WriteLine("Không tìm thấy thông tin sinh viên cần sửa!");
                return;
            }
            Console.WriteLine("Vui lòng nhập họ sinh viên: ");
            var ho = Console.ReadLine();
            sv.Ho = ho;
            Console.WriteLine("Vui lòng nhập tên sinh viên: ");
            var ten = Console.ReadLine();
            sv.Ten = ten;
            Console.WriteLine("Vui lòng nhập tuổi sinh viên: ");
            var tuoi = Console.ReadLine();
            sv.Tuoi = Int32.Parse(tuoi);
            // sv.Tuoi = Convert.ToInt32(tuoi);
            Console.WriteLine("Vui lòng nhập trạng thái sinh viên: ");
            var trangThai = Console.ReadLine();
            // sv.TrangThai = Convert.ToInt32(trangThai);
            bool result = _sinhVienModel.Update(maSinhVien, sv);
            if (result)
            {
                Console.WriteLine("Sửa thông tin sinh viên thành công!");   
            }
            else
            {
                Console.WriteLine("Có lỗi xảy ra, vui lòng thử lại sau.");
            }
        }
        
        public void XoaThongTinSinhVien()
        {
            Console.WriteLine("Vui lòng nhập mã số sinh viên cần xóa: ");
            var maSinhVien = Console.ReadLine();
            SInhVien sv = _sinhVienModel.FindById(maSinhVien);
            if (sv == null)
            {
                Console.WriteLine("khong tim thay thong tin sinh vien.");
                return;
            }

            Console.WriteLine($"tim thay sinh vien co ma: {sv.Ma}, ten la: {sv.Ho} {sv.Ten}");
            Console.WriteLine("Ban co chac muon xoa sinh vien nay khong (C/K) ?");
            string luaChon = Console.ReadLine();
            if (luaChon.ToLower().Equals("c"))
            {
                bool result = _sinhVienModel.Delete(maSinhVien);
                if (result)
                {
                    Console.WriteLine("Xoa thanh cong");
                }
                else
                {
                    Console.WriteLine("xoa that bai,vui long thu lai sau");
                }
            }
        }
    }
}