using System;

namespace _3._2._3
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

        static bool KiemTraSoHoanThien(int n)
        {
            int tong = 0;
            for (int i = 1; i <= n; i++) if (n % i == 0) tong += i;
            if (tong == n) return true;
            return false;
        }

        static int[] NhapMang(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham nhap mang_______________");

            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            A = new int[n];

            for (int i = 0; i < n; i++)
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

        // ______________________________BAI 90______________________________
        static void DemSoAmDuong(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham dem so am va so duong_______________");
            int am = 0, duong = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0) duong++;
                if (A[i] < 0) am++;
            }
            Console.WriteLine("Tong so am la: {0}", am);
            Console.WriteLine("Tong so duong la: {0}", duong);
        }

        // ______________________________BAI 91______________________________
        static void DemSoChanLe(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham dem so chan va so le_______________");
            int chan = 0, le = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0) chan++;
                if (A[i] % 2 != 0) le++;
            }
            Console.WriteLine("Tong so chan la: {0}", chan);
            Console.WriteLine("Tong so le la: {0}", le);
        }

        // ______________________________BAI 92______________________________
        static void DemSoLuongX(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham dem so lan x xuat hien_______________");
            Console.Write("Nhap phan tu x can tim: ");
            int x = int.Parse(Console.ReadLine());
            int dem = 0;

            for (int i = 0; i < A.Length; i++)
                if (A[i] == x) dem++;

            Console.WriteLine("Tong so lan x xuat hien la: " + dem);
        }

        // ______________________________BAI 93______________________________
        static void DemSoLuongNhoHonX(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham dem so luong so be hon x_______________");
            Console.Write("Nhap phan tu x can tim: ");
            int x = int.Parse(Console.ReadLine());
            int dem = 0;

            for (int i = 0; i < A.Length; i++)
                if (A[i] < x) dem++;

            Console.WriteLine("Tong so be hon x la: " + dem);
        }

        // ______________________________BAI 94______________________________
        static void DemSoLuongSoNguyenTo(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham dem so luong so nguyen to_______________");
            int dem = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (KiemTraSoNguyenTo(A[i])) dem++;
            }
            Console.WriteLine("Tong so luong so nguyen to la: " + dem);
        }

        // ______________________________BAI 95______________________________
        static void DemSoLuongSoHoanThien(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham dem so luong so hoan thien_______________");
            int dem = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (KiemTraSoHoanThien(A[i])) dem++;
            }
            Console.WriteLine("Tong so luong so hoan thien la: " + dem);
        }

        // ______________________________BAI 96______________________________
        static void DemSoBoiCua3Hoac5(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham dem so luong so la boi cua 3 hoac 5_______________");
            int dem3 = 0, dem5 = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 3 == 0) dem3++;
                if (A[i] % 5 == 0) dem5++;
            }
            Console.WriteLine("Tong so luong so chia het cho 3 la: " + dem3);
            Console.WriteLine("Tong so luong so chia het cho 5 la: " + dem5);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("______________________________MANG DEM - TAN SUAT______________________________");

            int[] A = new int[0];

            A = NhapMang(A);
            XuatMang(A);

            //DemSoAmDuong(A);

            //DemSoChanLe(A);

            //DemSoLuongX(A);

            //DemSoLuongNhoHonX(A);

            //DemSoLuongSoNguyenTo(A);

            //DemSoLuongSoHoanThien(A);

            //DemSoBoiCua3Hoac5(A);
        }
    }
}
