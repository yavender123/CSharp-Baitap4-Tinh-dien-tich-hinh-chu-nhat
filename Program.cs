using System;
class Bai4
{
    static void Main(string[] args)
    {
        //Loi mo dau
        Console.WriteLine($"Hello!");

        //Chieu dai
        Console.WriteLine($"Nhap chieu dai: ");
        if (!double.TryParse(Console.ReadLine(), out double dai))
        {
            Console.WriteLine($"Vo gia tri!");
            return;
        }
        
        //Chieu rong
        Console.WriteLine($"Nhap chieu rong: ");
        if (!double.TryParse(Console.ReadLine(), out double rong))
        {
            Console.WriteLine($"Vo gia tri!");
            return;
        }

        //Dieu kien
        if (dai <=0 || rong <=0)
        {
        Console.WriteLine($"Chieu dai va chieu rong phai lon hon 0");
        return;
        }

        //Tinh va in ket qua
         Console.WriteLine($"Dien tich hinh chu nhat: {dai * rong}");
    }
}