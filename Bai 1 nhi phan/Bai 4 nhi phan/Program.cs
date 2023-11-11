using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

[Serializable]
class SinhVien
{
    public string Ten { get; set; }
    public int Tuoi { get; set; }
    public string Nganh { get; set; }
}

class ChuongTrinh
{
    static void Main()
    {
        Console.OutputEncoding=Encoding.UTF8;
        List<SinhVien> danhSachSinhVien = new List<SinhVien>();

        Console.Write("Nhập số lượng sinh viên muốn nhập: ");
        int soLuongSinhVien = int.Parse(Console.ReadLine());

        for (int i = 0; i < soLuongSinhVien; i++)
        {
            Console.WriteLine($"Nhập thông tin sinh viên {i + 1}:");

            Console.Write("Tên sinh viên: ");
            string ten = Console.ReadLine();

            Console.Write("Tuổi: ");
            int tuoi = int.Parse(Console.ReadLine());

            Console.Write("Ngành: ");
            string nganh = Console.ReadLine();

            danhSachSinhVien.Add(new SinhVien { Ten = ten, Tuoi = tuoi, Nganh = nganh });
        }
        using (FileStream fileStream = new FileStream("sinhviens.dat", FileMode.Create))
        {
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, danhSachSinhVien);
        }

        Console.WriteLine("Danh sách sinh viên đã được lưu vào tệp sinhviens.dat.");

        using (FileStream fileStream = new FileStream("sinhviens.dat", FileMode.Open))
        {
            IFormatter formatter = new BinaryFormatter();
            List<SinhVien> sinhVienDaLoad = (List<SinhVien>)formatter.Deserialize(fileStream);

            Console.WriteLine("Danh sách sinh viên từ tệp sinhviens.dat:");
            foreach (var sinhvien in sinhVienDaLoad)
            {
                Console.WriteLine($"Tên: {sinhvien.Ten}, Tuổi: {sinhvien.Tuoi}, Ngành: {sinhvien.Nganh}");
            }
        }
    }
}
