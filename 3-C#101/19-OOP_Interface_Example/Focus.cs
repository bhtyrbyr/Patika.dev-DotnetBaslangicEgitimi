namespace _19_OOP_Interface_Example
{
    public class Focus : IOtomobil
    {
        public Marka HangiMarkaninARaci()
        {
            return Marka.Ford;
        }

        public int KacTekerketenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}