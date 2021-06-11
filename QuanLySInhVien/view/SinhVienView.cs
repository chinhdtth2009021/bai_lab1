using System;
using QuanLySInhVien.controller;

namespace QuanLySInhVien.view
{
    public class SinhVienView
    {
        private SinhVienController _sinhVienController = new SinhVienController();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("Quản lý sinh viên.");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1. Tạo mới sinh viên.");
                Console.WriteLine("2. Hiển thị danh sách sinh viên.");
                Console.WriteLine("3. Sửa thông tin sinh viên.");
                Console.WriteLine("4. Xóa thông tin sinh viên.");
                Console.WriteLine("5. Thoát chương trình.");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Nhập lựa chọn của bạn: (1->5).");
                int luaChon = Convert.ToInt32(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        _sinhVienController.TaoMoiSinhVien();
                        break;
                    case 2:
                        _sinhVienController.HienThiDanhSachSinhVien();
                        break;
                    case 3:
                        _sinhVienController.SuaThongTinSinhVien();
                        break;
                    case 4:
                        _sinhVienController.XoaThongTinSinhVien();
                        break;
                    case 5:
                        Console.WriteLine("Hẹn gặp lại.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn sai,vui lòng nhập lại lựa chọn từ 1->5");
                        break;
                }

                Console.ReadLine();
                if (luaChon == 5)
                {
                    break;
                }
            }
        }
    }
}