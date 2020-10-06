using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PERPUSTAKAAN
{
    /*1. Menu terdiri
     a.tambah buku(inputan)
     b.liat daftar buku(foreach)
     c.Pencarian buku berdasarkan nama buku(inputan)
     d.Insert buku(inputan)
     e.Hapus buku berdasarkan nama buku(inputan)
     f.Hapus semua buku*/
    public class Program
    {

        static ArrayList arr = new ArrayList();

        public static void Main(string[] args)
        {
            arr.Add("Harry Potter");
            arr.Add("Laskar Pelangi");

            Console.WriteLine(" ");
        menu:
            Console.WriteLine("||--------------------------------||");
            Console.WriteLine("PERPUSTAKAAN KELOMPOK 4");
            Console.WriteLine("||--------------------------------||");
            Console.WriteLine("1. Tambah Buku");
            Console.WriteLine("2. Lihat Daftar Buku");
            Console.WriteLine("3. Cari Buku (Nama)");
            Console.WriteLine("4. Insert Buku");
            Console.WriteLine("5. Hapus Buku (Nama)");
            Console.WriteLine("6. Hapus Semua Buku");
            Console.WriteLine("||--------------------------------||");
            Console.Write("Pilih : ");
            Program program = new Program();
            try
            {
                int pilih = int.Parse(Console.ReadLine());
                switch (pilih)

                {

                    case 1:
                        program.Inputan();
                        Console.WriteLine(" ");
                        goto menu;
                    case 2:
                        program.DaftarBuku();
                        if (arr.Count == 0)
                        {
                            Console.WriteLine("data tidak ditemukan :(");
                        }
                        Console.WriteLine(" ");
                        goto menu;
                    case 3:
                        program.Pencarian();
                        Console.WriteLine(" ");
                        goto menu;
                    case 4:
                        program.InsertBuku();
                        Console.WriteLine(" ");
                        goto menu;
                    case 5:
                        program.DeleteByName();
                        Console.WriteLine(" ");
                        goto menu;
                    case 6:
                        arr.Clear();
                        if (arr.Count == 0)
                        {
                            Console.WriteLine("Terhapus !!");
                        }
                        Console.WriteLine(" ");
                        goto menu;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine(" ");
                Console.WriteLine("Catch finally done");
                Console.WriteLine(" ");
            }
        }
       
        public void Inputan()
        {
            Console.Write("Tambahkan Buku : ");
            string z = Console.ReadLine();
            if (arr.Contains(z))
            {
                Console.WriteLine("buku " + z + " sudah ada di perpus :)");
            }
            else
            {
                arr.Add(z);
            }
            Console.WriteLine("Jumlah Buku Perpustakaan :" + arr.Count);
        }
        public void DaftarBuku()
        {
            foreach (string x in arr)
            {
                Console.WriteLine(x);
            }
        }
        public void Pencarian()
        {
            Console.Write("Masukkan Nama Buku : ");
            string z = Console.ReadLine();
            if (arr.Contains(z))
            {
                Console.WriteLine("buku "+z+" ditemukan");
            }
            else
            {
                Console.WriteLine("buku "+z+" tidak ditemukan");
            }
        }
        public void InsertBuku()
        {
            Console.Write("Urutan ke : ");
            int t = int.Parse(Console.ReadLine());
            Console.Write("Insert Buku : ");
            string s = Console.ReadLine();
            arr.Insert(t, s);
            Console.WriteLine("Jumlah Buku Perpustakaan : " + arr.Count);

            Console.WriteLine("||--------------------------------||");
            Console.WriteLine("Buku updated");
            Console.WriteLine("||--------------------------------||");
            foreach (string x in arr)
            {
                Console.WriteLine(x);
            };
        }
        public void DeleteByName()
        {
            Console.Write("Masukkan Nama Buku : ");
            string z = Console.ReadLine();
            if (arr.Contains(z))
            {
                arr.Remove(z);
                Console.WriteLine("buku " + z + " dihapus");
            }
            else
            {
                Console.WriteLine("buku " + z + " tidak ditemukan");
            }
        }
    }
}
