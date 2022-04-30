using System;

namespace _5_HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yaşınızı girin>");
            int yas = yaskontroledici(Console.ReadLine());
            Console.WriteLine(yas);
            
        }

        private static int yaskontroledici(string yas)
        {
            int yas_int;
            try
            {
                yas_int = int.Parse(yas);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Hata!\nYas değeri bos olamaz");
                Console.WriteLine(ex);
                return 0;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Hata!\nYas değeri sadece sayılardan oluşabilir");
                Console.WriteLine(ex);
                return 0;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Hata!\nÇok büyük veya çok küçük değer girdiniz");
                Console.WriteLine(ex);
                return 0;
            }
                return yas_int;
            
        }
    }
}
