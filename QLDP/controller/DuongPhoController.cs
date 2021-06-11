using System;
using System.Collections.Generic;
using System.Linq;
using QLDP.entity;
using QLDP.model;

namespace QLDP.controller
{
    public class DuongPhoController
    {
        private DuongPhoModel _duongPhoModel = new DuongPhoModel();

        public void TaoDuongPho()
        {
            Console.WriteLine("vui lòng nhập thông tin con đường");
            DuongPho duongPho = new DuongPho();
            Console.WriteLine("Vui lòng nhập mã: ");
            duongPho.Ma = Console.ReadLine();
            Console.WriteLine("Nhập tên đường: ");
            duongPho.Ten = Console.ReadLine();
            Console.WriteLine("Nhập mô tả: ");
            duongPho.MoTa = Console.ReadLine();
            Console.WriteLine("Nhập ngày sử dụng: ");
            duongPho.NgaySuDung = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhập lịch sử: ");
            duongPho.LichSu = Console.ReadLine();
            Console.WriteLine("Nhập tên quận: ");
            duongPho.TenQuan = Console.ReadLine();
            Console.WriteLine("Nhập trạng thái: ");
            duongPho.TrangThai = Convert.ToInt32(Console.ReadLine());
            bool result = _duongPhoModel.Save(duongPho);
            if (result)
            {
                Console.WriteLine("Tao moi duong pho thanh cong.");
            }
            else
            {
                Console.WriteLine("Tao moi duong pho that bai.");
            }
        }

        public void HienThiDanhSachDuongPho()
        {
            Console.WriteLine("Danh sách đường phố vừa nhập là: ");
            List<DuongPho> listDuongPho = _duongPhoModel.FindAll();
            for (var i = 0; i < listDuongPho.Count; i++)
            {
                var dp1 = listDuongPho[i];
                Console.WriteLine(
                    $"Mã: {dp1.Ma}, Tên: {dp1.Ten}, Mô tả: {dp1.MoTa}, Ngày sử dụng: {dp1.NgaySuDung}, Lịch sử: {dp1.LichSu}, Tên quận: {dp1.TenQuan}, Trạng thái: {dp1.TrangThai}");
                if (_duongPhoModel == null)
                {
                    Console.WriteLine("danh sach duong pho cua ban dang rong vui long nhap thong tin sinh vien");
                }
            }
        }

        public void SuaThongTinDuongPho()
        {
            Console.WriteLine("Vui lòng nhập mã đường phố: ");
            var ma = Console.ReadLine();
            DuongPho dp = _duongPhoModel.FindById(ma);
            if (dp == null)
            {
                Console.WriteLine("Không tìm thấy đường phố cần sửa!");
                return;
            }

            Console.WriteLine("Nhập tên đường cần sửa: ");
            dp.Ten = Console.ReadLine();
            Console.WriteLine("Nhập mô tả đường cần sửa: ");
            dp.MoTa = Console.ReadLine();
            Console.WriteLine("Nhập ngày sử dụng đường cần sửa: ");
            dp.NgaySuDung = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhập lịch sử đường cần sửa: ");
            dp.LichSu = Console.ReadLine();
            Console.WriteLine("Nhập tên quận đường cần sửa: ");
            dp.TenQuan = Console.ReadLine();
            Console.WriteLine("Nhập trạng thái đường cần sửa: ");
            dp.TrangThai = Convert.ToInt32(Console.ReadLine());
            bool result = _duongPhoModel.Update(ma, dp);
            if (result)
            {
                Console.WriteLine("Sửa thông tin duong pho thành công!");
            }
            else
            {
                Console.WriteLine("Có lỗi xảy ra, vui lòng thử lại sau.");
            }
        }

        public void XoaThongTinDuongPho()
        {
            Console.WriteLine("Vui lòng nhập mã đường phố cần xóa: ");
            var ma = Console.ReadLine();
            DuongPho dp = _duongPhoModel.FindById(ma);
            if (dp == null)
            {
                Console.WriteLine("Không tìm thấy đường phố cần xóa!");
                return;
            }

            Console.WriteLine($"Tìm thấy đường phố có mã: {dp.Ma},Tên là {dp.Ten}");
            Console.WriteLine("Bạn có chắc muốn xóa thông tin đường phố không (C/K)?");
            string luachon = Console.ReadLine();
            if (luachon.ToLower().Equals("c"))
            {
                bool result = _duongPhoModel.Delete(ma);
                if (result)
                {
                    Console.WriteLine("Xóa thành công.");
                }
                else
                {
                    Console.WriteLine("Xóa thất bại,vui lòng thử lại sau.");
                }
            }
        }
    }
}