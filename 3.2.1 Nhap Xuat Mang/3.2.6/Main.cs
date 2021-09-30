using System;

namespace Mang
{
    class Program
    {
        static bool KiemTraSoNguyenTo(int n)
        {
            if (n == 1) return false;
            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static bool KiemTraSoChinhPhuong(int n)
        {
            //double tmp = Math.Sqrt(n);
            if ((int)Math.Sqrt(n) * (int)Math.Sqrt(n) == n) return true;
            return false;
        }
        // ______________________________Bai 66______________________________
        static int[] NhapMang(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham nhap mang_______________");

            Console.Write("Nhap so luong phan tu cua mang 1 chieu: ");
            int n = int.Parse(Console.ReadLine());
            A = new int[n];
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i);
                A[i] = int.Parse(Console.ReadLine());
            }
            return A;
        }

        static void XuatMang(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham xuat mang_______________");

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
        }

        // ______________________________Bai 67______________________________
        static int[] TaoMang(int[] B)
        {
            Console.WriteLine("_______________Ban da goi ham tao mang[0, n]_______________");

            Console.Write("Nhap so luong phan tu n: ");
            int n = int.Parse(Console.ReadLine());
            B = new int[n];

            for (int i = 0; i < B.Length; i++)
            {
                B[i] = i;
            }
            XuatMang(B);

            return B;
        }

        // ______________________________Bai 68______________________________
        static int[] TaoMangNgauNhienAm(int[] A)
        {
            System.Random random = new System.Random();
            Console.WriteLine("_______________Ban da goi ham tao mang am ngau nhien_______________");

            Console.Write("Nhap so luong phan tu n: ");
            int n = int.Parse(Console.ReadLine());
            A = new int[n];
            
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = random.Next(minValue: -9999, maxValue: 0);
            }
            XuatMang(A);
            return A;
        }

        // ______________________________Bai 69______________________________
        static int[] TaoMangNgauNhienTangDan(int[] A)
        {
            System.Random random = new System.Random();
            Console.WriteLine("_______________Ban da goi ham tao mang ngau nhien tang dan_______________");

            Console.Write("Nhap so luong phan tu n: ");
            int n = int.Parse(Console.ReadLine());
            A = new int[n];

            A[0] = random.Next(minValue: 0, maxValue: 9999);

            for (int i = 1; i < A.Length; i++)
            {
                A[i] = A[i - 1] + random.Next(minValue: 0, maxValue: 9999);
            }
            XuatMang(A);
            return A;
        }

        // ______________________________Bai 70______________________________
        static void NhapVaXuatSoAm(int [] A)
        {
            Console.WriteLine("_______________Ban da goi ham nhap va xuat mang so am_______________");

            A = NhapMang(A);
            
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0) Console.Write(A[i] + " ");
            }
            Console.WriteLine();

        }

        // ______________________________Bai 71______________________________
        static void NhapVaXuatSoLe(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham nhap va xuat mang so le_______________");

            A = NhapMang(A);

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 != 0) Console.Write(A[i] + " ");
            }
            Console.WriteLine();

        }

        // ______________________________Bai 72______________________________
        static void NhapVaXuatSoChan(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham nhap va xuat mang so chan va be hon 20_______________");

            A = NhapMang(A);

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0 && A[i] < 20) Console.Write(A[i] + " ");
            }
            Console.WriteLine();

        }

        // ______________________________Bai 73______________________________
        static void NhapVaXuatSoNguyenTo(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham nhap va xuat mang so nguyen to_______________");

            A = NhapMang(A);

            for (int i = 0; i < A.Length; i++)
            {
                if (KiemTraSoNguyenTo(A[i])) Console.Write(A[i] + " ");
            }
            Console.WriteLine();

        }

        // ______________________________Bai 74______________________________
        static void NhapVaXuatSoChinhPhuong(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham nhap va xuat mang so chinh phuong tai vi tri le_______________");

            A = NhapMang(A);

            for (int i = 0; i < A.Length; i++)
            {
                if (i % 2 != 0 && KiemTraSoChinhPhuong(A[i])) Console.Write(A[i] + " ");
            }
            Console.WriteLine();

        }

        static void Main(string[] args)
        {
            Console.WriteLine("______________________________MANG______________________________");

            int[] A = new int[0];

            //A = NhapMang(A);

            //XuatMang(A);

            //A = TaoMang(A);

            //A = TaoMangNgauNhienAm(A);

            //A = TaoMangNgauNhienTangDan(A);

            //NhapVaXuatSoAm(A);

            //NhapVaXuatSoLe(A);

            //NhapVaXuatSoChan(A);

            //NhapVaXuatSoNguyenTo(A);

            //NhapVaXuatSoChinhPhuong(A);
        }
    }
}
