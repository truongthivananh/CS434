using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1
{
    class Cau1
    {
        static int Nhap()
        {
            int n;
            do
            {
                Console.Write("Nhập vào số phần tử: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);
            return n;
        }

        //a. Nhập mảng
        static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        //b. Xuất mảng
        static void XuatMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }Console.WriteLine();
        }
        //c. Tính toán
        static void TongVaTBC(int[] a)
        {
            int tong = 0;
            for (int i = 0; i < a.Length; i++)
            {
                tong += a[i];
            }
            double tbc = (double)tong / a.Length;
            Console.WriteLine($"Tổng các phần tử: {tong}");
            Console.WriteLine($"Trung bình cộng các phần tử: {tbc:F2}");
        }
        //d. Sắp xếp và đảo ngược
        static void SapXepVaDaoNguoc(int[] a)
        {
            int[] tangDan = (int[])a.Clone();
            Array.Sort(tangDan);
            Console.Write("Mảng tăng dần: ");
            XuatMang(tangDan);

            int[] giamDan = (int[])a.Clone();
            Array.Sort(giamDan);
            Array.Reverse(giamDan);
            Console.Write("Mảng giảm dần: ");
            XuatMang(giamDan);

            int[] daoNguoc = (int[])a.Clone();
            Array.Reverse(daoNguoc);
            Console.Write("Mảng đảo ngược: ");
            XuatMang(daoNguoc);
        }
        //e. Tìm kiếm 
        static void TimX(int[] a)
        {
            Console.Write("Nhập số x cần tìm: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (Array.IndexOf(a, x) >= 0)
                Console.WriteLine($"Số {x} có trong mảng");
            else
                Console.WriteLine($"Số {x} không có trong mảng");
        }
        //f
        static bool KiemTraSNT(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static List<int> LocSNT_List(int[] a)
        {
            List<int> dsSNT = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (KiemTraSNT(a[i]))
                {
                    dsSNT.Add(a[i]);
                }
            }
            return dsSNT;
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int n = Nhap();
            int[] a = new int[n];
            NhapMang(a, n);

            Console.Write("\nCác phần tử trong mảng: ");
            XuatMang(a);

            TongVaTBC(a);

            SapXepVaDaoNguoc(a);

            TimX(a);

            List<int> ketQuaList = LocSNT_List(a);
            Console.Write("Mảng các số nguyên tố: ");
            Console.WriteLine(string.Join(" ", ketQuaList));

            Console.ReadKey();
        }
    }
}
