namespace _20_OOP_Abstract_Class
{
    public class Corolla : IOtomobil
    {
        public Marka HangiMarkaninARaci()
        {
            return Marka.Toyota;
        }

        public int KacTekerketenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}