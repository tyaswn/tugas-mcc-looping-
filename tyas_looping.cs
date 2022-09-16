using System;

namespace MCCDTS1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("-----------looping Absensi Karyawan Bulan September---------------");
            int[] value = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            for (int i = 0; i < value.Length; i++)
            {
                Console.WriteLine("Absensi Karyawan Hari ke" + value[i]);
            }

            int angka = 0;
            while (angka < 12)
            {
                Console.WriteLine("Absensi Karyawan Hari ke-" + angka);
                angka = angka + 1;
            }
            Console.ReadLine();
        }
    }
}
