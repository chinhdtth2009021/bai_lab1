using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using QLDP.entity;
using QLDP.helper;

namespace QLDP.model
{
    public class DuongPhoModel
    {
        public bool Save(DuongPho duongPho)
        {
            var connection = HelPer.GetConnection();
            connection.Open();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText =
                $"INSERT INTO quanlyduongpho (Ma,Ten,MoTa,NgaySuDung,LichSu,TenQuan,TrangThai) " +
                $"VALUES ('{duongPho.Ma}', '{duongPho.Ten}', '{duongPho.MoTa}', '{duongPho.NgaySuDung}','{duongPho.LichSu}', '{duongPho.TenQuan}', {duongPho.TrangThai});";
            var result = mySqlCommand.ExecuteNonQuery();
            connection.Close();
            if (result == 1)
            {
                return true;
            }

            return false;
        }

        public List<DuongPho> FindAll()
        {
            var listDuongPho = new List<DuongPho>();
            var connection = HelPer.GetConnection();
            connection.Open();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"select * from quanlyduongpho";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                string ma = mySqlDataReader.GetString("Ma");
                string ten = mySqlDataReader.GetString("Ten");
                string moTa = mySqlDataReader.GetString("MoTa");
                DateTime ngaySuDung = mySqlDataReader.GetDateTime("NgaySuDung");
                string lichSu = mySqlDataReader.GetString("LichSu");
                string tenQuan = mySqlDataReader.GetString("TenQuan");
                int trangThai = mySqlDataReader.GetInt32("TrangThai");
                DuongPho duongPho = new DuongPho();
                duongPho.Ma = ma;
                duongPho.Ten = ten;
                duongPho.MoTa = moTa;
                duongPho.NgaySuDung = ngaySuDung;
                duongPho.LichSu = lichSu;
                duongPho.TenQuan = tenQuan;
                duongPho.TrangThai = trangThai;
                listDuongPho.Add(duongPho);
            }

            mySqlDataReader.Close();
            return listDuongPho;
        }

        public DuongPho FindById(string id)
        {
            DuongPho duongPho = null;
            var connection = HelPer.GetConnection();
            connection.Open();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"select * from quanlyduongpho where Ma = '{id}'";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            if (mySqlDataReader.Read())
            {
                string ma = mySqlDataReader.GetString("Ma");
                string ten = mySqlDataReader.GetString("Ten");
                string moTa = mySqlDataReader.GetString("MoTa");
                var ngaySuDung = mySqlDataReader.GetDateTime("NgaySuDung");
                string lichSu = mySqlDataReader.GetString("LichSu");
                string tenQuan = mySqlDataReader.GetString("TenQuan");
                int trangThai = mySqlDataReader.GetInt32("TrangThai");
                duongPho = new DuongPho();
                duongPho.Ma = ma;
                duongPho.Ten = ten;
                duongPho.MoTa = moTa;
                duongPho.NgaySuDung = ngaySuDung;
                duongPho.LichSu = lichSu;
                duongPho.TenQuan = tenQuan;
                duongPho.TrangThai = trangThai;
            }

            connection.Close();
            return duongPho;
        }

        public bool Update(string ma, DuongPho updateDuongPho)
        {
            DuongPho duongPho = FindById(ma);
            if (duongPho == null)
            {
                return false;
            }

            duongPho.Ten = updateDuongPho.Ten;
            duongPho.MoTa = updateDuongPho.MoTa;
            duongPho.NgaySuDung = updateDuongPho.NgaySuDung;
            duongPho.LichSu = updateDuongPho.LichSu;
            duongPho.TenQuan = updateDuongPho.TenQuan;
            duongPho.TrangThai = updateDuongPho.TrangThai;
            var connection = HelPer.GetConnection();
            connection.Open();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText =
                $"update quanlyduongpho set Ten = '{duongPho.Ten}', MoTa = '{duongPho.MoTa}',NgaySuDung = '{duongPho.NgaySuDung}', LichSu = '{duongPho.LichSu}', TenQuan = '{duongPho.TenQuan}', TrangThai = {duongPho.TrangThai} ";
            int result = mySqlCommand.ExecuteNonQuery();
            connection.Close();
            if (result == 1)
            {
                return true;
            }

            return false;
        }

        public bool Delete(string id)
        {
            DuongPho duongPho = FindById(id);
            if (duongPho == null)
            {
                return false;
            }

            var connection = HelPer.GetConnection();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            connection.Open();
            mySqlCommand.CommandText = $"delete from quanlyduongpho where Ma = '{id}'";
            int result = mySqlCommand.ExecuteNonQuery();
            connection.Close();
            if (result == 1)
            {
                return true;
            }

            return false;
        }
    }
}