using System;

namespace degiskenler
{
    class Program
    {

        static void Main(string[] args)
        {

            // değişken tanımlamarı
            byte sayi_byte = 1;
            sbyte sayi_sbyte = 1;

            short sayi_short = 1;
            ushort sayi_ushort = 1;
            
            Int16 sayi_int16 = 1;
            UInt16 sayi_uint16 = 1;

            int sayi_int = 1;
            uint sayi_uint = 1;

            Int32 sayi_int32 = 1;
            UInt32 sayi_uint32 = 1;

            long sayi_long = 1;
            ulong sayi_ulong = 1;

            Int64 sayi_int64 = 1;
            UInt64 sayi_uint64 = 1;

            char chr = 'a';
            
            string str = "string";

            DateTime dt = DateTime.Now();

            // dönüşümler

            //sayi -> string
            string say_int16_to_str = sayi_int16.ToString();

            // string -> sayi (Parse)
            string str_sayi = "5"
            Int16 str_to_sayi_Int16 = Int16.Parse(str_sayi);

            // string -> sayi (Convert)
            Int32 str_sayi_to_sayi_Int32 = Convert.ToInt32(str_sayi);

            Console.WriteLine(dt_str);

        }
    }
}
