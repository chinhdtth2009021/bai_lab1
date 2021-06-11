using System.Collections.Generic;
using MySql.Data.MySqlClient;
using QuanLySInhVien.entity;
using QuanLySInhVien.helper;

namespace QuanLySInhVien.model
{
    public class DuongSinhDbModel
    {
        public List<SInhVien> FindAll()
        {
            List<SInhVien> _listSinhVien = new List<SInhVien>();
            var connection =ConnectionHelper .GetConnection();
            connection.Open();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"select * from sinhviens";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                string ma = mySqlDataReader.GetString("Ma");
                string ho = mySqlDataReader.GetString("Ho");
                string ten = mySqlDataReader.GetString("Ten");
                int tuoi = mySqlDataReader.GetInt32("Tuoi");
                int trangThai = mySqlDataReader.GetInt32("TrangThai");
                SInhVien sinhVien = new SInhVien();
                sinhVien.Ma = ma;
                sinhVien.Ho = ho;
                sinhVien.Ten = ten;
                sinhVien.Tuoi = tuoi;
                sinhVien.TrangThai = trangThai;
                _listSinhVien.Add(sinhVien);
                
            }
            mySqlDataReader.Close();
            return _listSinhVien;
        }

        
        public bool Save(SInhVien sinhVien)
        {
            var connection = ConnectionHelper.GetConnection();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"insert into sinhviens (Ma, Ho, Ten, Tuoi, TrangThai) values " +
                                       $"('{sinhVien.Ma}', '{sinhVien.Ho}', '{sinhVien.Ten}', {sinhVien.Tuoi} , {sinhVien.TrangThai})";
            int result = mySqlCommand.ExecuteNonQuery();
            connection.Close();
            if (result == 1)
            {
                return true;
            }
            return false;
        }

        public SInhVien FindById(string id)
        {
            SInhVien sinhVien = null;
            var connection = ConnectionHelper.GetConnection();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"select * from sinhviens where Ma = '{id}'";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            if (mySqlDataReader.Read())
            {
                string ma = mySqlDataReader.GetString("Ma");
                string ho = mySqlDataReader.GetString("Ho");
                string ten = mySqlDataReader.GetString("Ten");
                int tuoi = mySqlDataReader.GetInt32("Tuoi");
                int trangThai = mySqlDataReader.GetInt32("TrangThai");
                sinhVien = new SInhVien();
                sinhVien.Ma = ma;
                sinhVien.Ho = ho;
                sinhVien.Ten = ten;
                sinhVien.Tuoi = tuoi;
                sinhVien.TrangThai = trangThai;
            }
            mySqlDataReader.Close();
            return sinhVien;
        }

        public bool Update(string id, SInhVien updateSinhVien)
        {
            SInhVien sinhVien = FindById(id);
            if (sinhVien == null)
            {
                return false;
            }
            sinhVien.Ho = updateSinhVien.Ho;
            sinhVien.Ten = updateSinhVien.Ten;
            sinhVien.Tuoi = updateSinhVien.Tuoi;
            sinhVien.TrangThai = updateSinhVien.TrangThai;
            var connection = ConnectionHelper.GetConnection();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"update sinhviens set Ho = '{sinhVien.Ho}', Ten='{sinhVien.Ten}', tuoi={sinhVien.Tuoi},trangthai = {sinhVien.TrangThai} where MaSinhVien = '{id}'";
            int result = mySqlCommand.ExecuteNonQuery();
            if (result == 1)
            {
                return true;
            }
            return false;
        }
        
        public bool Delete(string id)
        {
            SInhVien sinhVien = FindById(id);
            if (sinhVien == null)
            {
                return false;
            }
            var connection = ConnectionHelper.GetConnection();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"delete from sinhviens where MaSinhVien = '{id}'";
            int result = mySqlCommand.ExecuteNonQuery();
            if (result == 1)
            {
                return true;
            }
            return false;
        }
    }
}