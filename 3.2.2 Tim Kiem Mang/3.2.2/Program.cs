using System;

namespace _3._2._2
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

        static int TimX(int[] A, int x)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == x) return i;
            }
            return -1;
        }

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

        // ______________________________Bai 75______________________________
        static int TimXCuoi(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham tim vi tri x cuoi cung_______________");

            Console.Write("Nhap x de tim: ");
            int x = int.Parse(Console.ReadLine());

            int tmp = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == x) tmp = i;
            }

            Console.WriteLine(tmp);

            return tmp;
        }

        // ______________________________Bai 76______________________________
        static int TimMin(int[] A)
        {
            int min = 9999999, vitri = -1;
            Console.WriteLine("_______________Ban da goi ham tim vi tri gia tri min_______________");

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                    vitri = i;
                }
            }
            Console.WriteLine("Vi tri so nho nhat la: " + vitri);
            return vitri;
        }

        // ______________________________Bai 77______________________________
        static int TimMax(int[] A)
        {
            int max = -9999999, vitri = -1;
            Console.WriteLine("_______________Ban da goi ham tim vi tri gia tri max_______________");

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                    vitri = i;
                }
            }
            Console.WriteLine("Vi tri so lon nhat la: " + vitri);
            return vitri;
        }

        // ______________________________Bai 78______________________________
        static int TimSoNguyenTo(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham tim vi tri so nguyen to_______________");

            int vitri = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (KiemTraSoNguyenTo(A[i]))
                {
                    Console.Write(i + " ");
                    vitri = i;
                }
            }
            return vitri;
        }

        // ______________________________Bai 79______________________________
        static int TimSoNguyenToLonHon23(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham tim vi tri so nguyen to lon hon 23_______________");

            int vitri = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (KiemTraSoNguyenTo(A[i]) && A[i] > 23)
                {
                    Console.Write(i + " ");
                    vitri = i;
                }
            }
            return vitri;
        }

        // ______________________________Bai 80______________________________
        static int TimSoAmDauTien(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham tim vi tri so am dau tien trong mang_______________");

            int vitri = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0)
                {
                    Console.WriteLine(i + " ");
                    vitri = i;
                    return vitri;
                }
            }
            Console.WriteLine("-1");
            return vitri;
        }

        // ______________________________Bai 81______________________________
        static int TimMaxAm(int[] A)
        {
            int max = -9999999, vitri = -1;
            Console.WriteLine("_______________Ban da goi ham tim vi tri max cua so am_______________");

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > max && A[i] < 0)
                {
                    max = A[i];
                    vitri = i;
                }
            }
            Console.WriteLine("Vi tri so lon nhat cua so am la: " + vitri);
            return vitri;
        }

        // ______________________________Bai 82______________________________
        static int TimSoDuongDauTien(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham tim vi tri so duong dau tien trong mang_______________");

            int vitri = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    Console.WriteLine(i);
                    vitri = i;
                    return vitri;
                }
            }
            Console.WriteLine("-1");
            return vitri;
        }

        // ______________________________Bai 83______________________________
        static int TimMinDuong(int[] A)
        {
            int min = 9999999, vitri = -1;
            Console.WriteLine("_______________Ban da goi ham tim vi tri gia tri min cua so duong_______________");

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < min && A[i] > 0)
                {
                    min = A[i];
                    vitri = i;
                }
            }
            Console.WriteLine("Vi tri so nho nhat cua so duong la: " + vitri);
            return vitri;
        }

        // ______________________________Bai 84______________________________
        static int[] TimBoiCua3Hoac5(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham tim boi cua 3 hoac 5 trong mang_______________");

            int dem = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 3 == 0 || A[i] % 5 == 0)
                    dem++;
            }

            int[] B = new int[dem];
            dem = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 3 == 0 || A[i] % 5 == 0)
                    B[dem++] = A[i];
            }

            XuatMang(B);

            return B;
        }

        // ______________________________Bai 85______________________________
        static int TimSoChanCuoiCung(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham tim so chan cuoi cung trong mang_______________");

            int tmp = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    tmp = A[i];
                }
            }
            Console.WriteLine(tmp);
            return tmp;
        }

        // ______________________________Bai 86______________________________
        static int TimSoLeMax(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham tim so chan cuoi cung trong mang_______________");

            bool check = false;
            int max = -99999;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 != 0 && A[i] > max)
                {
                    max = A[i];
                    check = true;
                }
            }
            if (check == true) Console.WriteLine(max);
            else Console.WriteLine("-1");
            return max;
        }

        // ______________________________Bai 87______________________________
        static int[] TimVaDoiChoMaxMin(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham tim va doi cho max va min trong mang_______________");

            int max = TimMax(A);
            int min = TimMin(A);

            int tmp = A[max];
            A[max] = A[min];
            A[min] = tmp;

            XuatMang(A);

            return A;
        }

        // ______________________________Bai 88______________________________
        static int[] Tu1DenX(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham tim tu 1 den X_______________");

            Console.Write("Nhap x de tim: ");
            int x = int.Parse(Console.ReadLine());

            int dem = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= x && A[i] >= 1)
                    dem++;
            }

            int[] B = new int[dem];
            dem = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= x && A[i] >= 1)
                {
                    B[dem] = A[i];
                    dem++;
                }
            }

            XuatMang(B);

            return B;
        }

        // ______________________________Bai 89______________________________
        static bool SoSanh2Mang(int[] A)
        {
            Console.WriteLine("_______________Ban da goi ham so sanh 2 mang_______________");

            Console.WriteLine("Nhap them 1 mang de so sanh");

            int[] B = new int[0];
            B = NhapMang(B);
            int dem1 = 0, dem2 = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (TimX(B, A[i]) == -1) dem1++;
                if (TimX(B, A[i]) != -1) dem2++;
            }
            int[] C = new int[dem1];
            int[] D = new int[dem2];

            dem1 = 0; dem2 = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (TimX(B, A[i]) == -1) C[dem1++] = A[i];
                if (TimX(B, A[i]) != -1) D[dem2++] = A[i];
            }

            XuatMang(C);
            XuatMang(D);

            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("______________________________MANG TIM KIEM______________________________");

            int[] A = new int[0];
            A = NhapMang(A);


            //TimXCuoi(A);

            //TimMin(A);

            //TimMax(A);

            //TimSoNguyenTo(A);

            //TimSoNguyenToLonHon23(A);

            //TimSoAmDauTien(A);

            //TimMaxAm(A);

            //TimSoDuongDauTien(A);

            //TimMinDuong(A);

            //TimBoiCua3Hoac5(A);

            //TimSoChanCuoiCung(A);

            //TimSoLeMax(A);

            //TimVaDoiChoMaxMin(A);

            //Tu1DenX(A);

            SoSanh2Mang(A);
        }
    }
}
