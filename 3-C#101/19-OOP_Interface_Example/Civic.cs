namespace _19_OOP_Interface_Example
{
    public class Civic : IOtomobil
    {
        public Marka HangiMarkaninARaci()
        {
            return Marka.Honda;
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