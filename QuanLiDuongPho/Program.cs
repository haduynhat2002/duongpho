using MySql.Data.MySqlClient;
using QuanLiDuongPho.helper;
using QuanLiDuongPho.view;

namespace QuanLiDuongPho
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DuongPhoMenu duongPhoMenu = new DuongPhoMenu();
            duongPhoMenu.Menu();
        }
    }
}