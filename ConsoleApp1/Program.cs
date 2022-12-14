using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        //Deklarasi array int dengan ukuran 20
        private int[] a = new int[20];
        //Deklarasi variabel int untuk menyimpan banyak data pada array 
        private int n;
        // Fungsi /method untuk menerima masukan 
        public void read()
        {
            // Menerima Angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("_______________");
            Console.WriteLine("Masukkan Elemen Array");
            Console.WriteLine("________________");

            //Pengguna Memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("________________________________");
            Console.WriteLine("Elemen Array Yang Telah Tersusun");
            Console.WriteLine("________________________________");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");

            public void BubbleSortArray()
            {
                for (int i = 1; i < n; i++) //For n - 1 passes 
                {
                    // Pada pass i, bandingkan n - i elemen pertama dengan elemen selanjutnya
                    for (int j = 0; j < n - i; j++)
                    {
                        if (a[j] > a[j + 1])
                        // Jika eleman tidak dalam urutan yang benar
                        {
                            //Tukar elemen 
                            int temp;
                            temp = a[j];
                            a[j] = a[j + 1];
                            a[j + 1] = temp;


                        }
                    }
                }

            }

            static void Main(string[] args)
            {
                // Creating the object of BubbleSort class
                Program mylist = new Program();

                //Pemanggil fungsi untuk menerima elemen array
                mylist.read();
                //Pemnaggil fungsi untuk mengurutkan array

                //Pemanggil fungsi untuk menampilkan array yang tersusun
                mylist.display();
                //Exit
                Console.WriteLine("\n|nTekan Tombol apa saja untuk Keluar.");
            }
        }
    }
}
