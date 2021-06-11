using System.Collections.Generic;
using QuanLySInhVien.entity;

namespace QuanLySInhVien.model
{
    public class SInhVienModel
    {
         /*
         * Class này thực hiện các thao tác liên quan đến database để lưu trữ,thêm,sửa,xóa dữ liệu.
     * Ở đây k nên thực hiện các thao tác liên quan đến nhiệm vụ bài toán mà chỉ thực hiện các câu lệnh
     * liên quan đến insert, update, delete, select.
     * Trong phạm vi bài hôm nay, chúng ta sẽ thực hiện lưu trữ vào memory, cho nên tất cả các thao tác thêm, sửa, xóa
     * đều sẽ được thực hiện trên 1 biến chứa danh sách sinh viên. Các hàm cần có là:
     * 1. Hàm findAll trả về danh sách sinh viên.
     * 2. Hàm save Nhận tham số đầu vào là đối tượng của lớp sinh viên,
     * thực hiện lưu trữ tham số vào danh sách. Trả về boolean.
     * 3. Hàm FindById  nhận tham số đầu vào là mã sinh viên, hàm sẽ tìm kiếm trong danh sách sinh viên đối tươngj
     * có trùng id trong danh sách và trả về , trường hợp không tìm thấy trả về null.
     * 4. Hàm update nhận tham số đầu vào là đối tượng của lớp sinh viên , thực hiện update thông tin dối tượng
     * này vào danh sách và trả về boolean.
     * 5. Hàm delete nhận danh sách đầu vào là id sinh viên , thực hiện xóa thông tn sinh viên có trùng id trong danh sách.
     */
        private List<SInhVien> _listSinhVien = new List<SInhVien>();
        
        public List<SInhVien> FindAll()
        {
            return _listSinhVien;
        }

        public bool Save(SInhVien sinhVien)
        {
            _listSinhVien.Add(sinhVien);
            return true;
        }
        public SInhVien FindById(string id)
        {
            for (int i = 0; i < _listSinhVien.Count; i++)
            {
                var sv = _listSinhVien[i];
                if (sv.Ma == id)
                {
                    return sv;
                }
            }
            return null;
        }

        public bool Update(string id, SInhVien updateSinhVien)
        {
            SInhVien sinhVien1 = FindById(id);
            if (sinhVien1 == null)
            {
                return false;
            }

            sinhVien1.Ho = updateSinhVien.Ho;
            sinhVien1.Ten = updateSinhVien.Ten;
            sinhVien1.Tuoi = updateSinhVien.Tuoi;
            sinhVien1.TrangThai = updateSinhVien.TrangThai;
            return true;
        }
        
        public bool Delete(string id)
        {
            SInhVien sinhVien2 = FindById(id);
            if (sinhVien2 == null)
            {
                return false;
            }

            _listSinhVien.Remove(sinhVien2);
            return true;
        }
    }
}
