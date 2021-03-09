/*
Tugas Praktek Pertama Matkul Pemrograman
Nama : Gading Al-Azam Purnama
NIM : 20.11.3408
Kelas : 20 Informatika 02
*/ 

using System;

namespace Kalkulator
{
    class Program
    {
        static void method(string[] args)
        {
        }
        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            Console.Write("\n \t Inputkan nilai A = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("\t Inputkan nilai B = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Menu Operasi Aljabar ");

            Console.WriteLine("+--------------------+");

            Console.WriteLine("|  1. Penambahan     |");
            Console.WriteLine("|  2. Pengurangan    |");
            Console.WriteLine("|  3. Perkalian      |");
            Console.WriteLine("|  4. Pembagian      |");

            Console.WriteLine("+--------------------+ ");


            Console.Write("Silahkan Pilih 1 sampai 4 = ");
            int menu = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Hasil Penambahan  " + a + " + " + b + " = " + penambahan(a, b));
                    break;
                case 2:
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
                    break;
                case 3:
                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
                    break;
                case 4:
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, pembagian(a, b));
                    break;
            }

            Console.WriteLine();
            if (menu > 4)
            {
                Console.WriteLine(" Mohon Maaf \n Pilihan Anda Salah \n Silahkan Ulang Program!");
            }
            else
            {

            }

            Console.WriteLine("\n Untuk keluar dari program \n Silahkan Tekan Sembarang Tombol");
            Console.ReadKey();
        }
    }
}
