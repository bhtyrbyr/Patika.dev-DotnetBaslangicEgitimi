using System;

namespace _20_OOP_Abstract_Class
{
    public class OtomobilManager :  IOtomobil
    {
        IOtomobil _otomobil;

        public OtomobilManager(IOtomobil otomobil)
        {
            this._otomobil = otomobil;
            HangiMarkaninARaci();
            KacTekerketenOlusur();
            StandartRengiNe();
        }

        public Marka HangiMarkaninARaci()
        {
            Console.WriteLine("Marka: " + _otomobil.HangiMarkaninARaci());
            return _otomobil.HangiMarkaninARaci();
        }

        public int KacTekerketenOlusur()
        {
            Console.WriteLine("Teker sayısı: " + _otomobil.KacTekerketenOlusur());
            return _otomobil.KacTekerketenOlusur();
        }

        public Renk StandartRengiNe()
        {
            Console.WriteLine("Standart rengi: " + _otomobil.StandartRengiNe());
            return _otomobil.StandartRengiNe();
        }
    }
}