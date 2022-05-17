namespace _19_OOP_Interface_Example
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