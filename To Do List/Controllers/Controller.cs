using To_Do_List.Models; // Sesuaikan namespace dengan project kamu
using System;
using System.Data;

namespace To_Do_List.Controllers
{
    public class Controller
    {
        private CRUD crud;

        public Controller()
        {
            crud = new CRUD();
        }

        // Tambah tugas
        public void TambahTugas(string deadline, string tugas, string deskripsi)
        {
            try
            {
                crud.TambahTugas(deadline, tugas, deskripsi);
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menambahkan tugas: " + ex.Message);
            }
        }

        // Ambil semua data tugas
        public DataTable TampilTugas()
        {
            try
            {
                return crud.LoadTugas();
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil data tugas: " + ex.Message);
            }
        }

        // Update tugas
        public void UbahTugas(int id, string deadline, string tugas, string deskripsi)
        {
            try
            {
                crud.UpdateTugas(id, deadline, tugas, deskripsi);
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengubah tugas: " + ex.Message);
            }
        }

        // Hapus tugas
        public void DeleteTugas(int id)
        {
            try
            {
                crud.HapusTugas(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menghapus tugas: " + ex.Message);
            }
        }

        // Login user
        public bool LoginUser(string username, string password)
        {
            try
            {
                return crud.Login(username, password);
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal login: " + ex.Message);
            }
        }
    }
}