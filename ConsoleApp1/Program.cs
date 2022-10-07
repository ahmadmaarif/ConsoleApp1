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
        private int[] a= new int[20];
        //Deklarasi variabel int untuk menyimpan banyak data pada array 
        private int n;
        // Fungsi /method untuk menerima masukan 
        public void read ()
        {
            // Menerima Angka untuk menentukan banyaknya data yang disimpan pada array
            while(true)
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
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }
        
        static void Main(string[] args)
        {
        }
    }
}
