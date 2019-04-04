using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace JSON
{
    public class FileDS
    {
        public int SoLuong { get; set; }
        public List<DanhSach> DanhSachHocSinh { get; set; }
    }
    public class DanhSach
    {
        public int ID { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public int Tuoi { get; set; }

        public DanhSach(int _ID, string _HoTen, string _GioiTinh, int _Tuoi)
        {
            ID = _ID;
            HoTen = _HoTen;
            GioiTinh = _GioiTinh;
            Tuoi = _Tuoi;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<DanhSach> List = new List<DanhSach>();
            for (int i = 0; i<10000; i++)
            {
                List.Add(new DanhSach(i, HoTen(), GioiTinh(), Tuoi()));
            }
            FileDS Output = new FileDS();
            Output.SoLuong = 10000;
            Output.DanhSachHocSinh = List;

            string str = JsonConvert.SerializeObject(Output);
            File.WriteAllText(@"C:\Users\Administrator\Desktop\DanhSach.json", str);

            Console.ReadKey();
        }
        static Random rd = new Random();
        static string HoTen()
        {
            
            List<string> LastName = new List<string>() { "Nguyen", "Pham", "Hoang", "Le", "Phan", "Vu", "Ly", "Tran", "Dang", "Huynh", "Vo", "Bui", "Do", "Ngo", "Duong" };
            int i = rd.Next(LastName.Count);
            List<string> MiddleName = new List<string>() { "Cong", "Pham", "Tran", "Le", "Hoang", "Cao", "Van", "Ly", "Sy Cong" };
            int j = rd.Next(MiddleName.Count);
            List<string> FirstName = new List<string>() { "Nguyen", "Thi", "Hoang", "Le", "Phan", "Vu", "Ly", "Tran", "Dang", "Huynh", "Vo", "Bui", "Do", "Ngo", "Duong", "Hai", "An", "Quang", "Huan", "Uyen", "Truong", "Sang", "Tuan", "Huy", "Huyen", "Anh", "Quynh", "Lan", "Hau" };
            int v = rd.Next(FirstName.Count);

            string FullName;
            FullName = LastName[i] + " " + MiddleName[j] + " " + FirstName[v];

            return FullName;
        }
        static int Tuoi()
        {
            int i = rd.Next(1, 100);
            return i;
        }
        static string GioiTinh()
        {
            List<string> GT = new List<string>() { "Nam", "Nu"};
            int i = rd.Next(GT.Count);
            string GioiTinh;
            GioiTinh = GT[i];
            return GioiTinh;
        }
        

    }
}
