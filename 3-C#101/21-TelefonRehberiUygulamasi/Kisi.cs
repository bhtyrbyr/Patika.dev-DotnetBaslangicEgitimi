using System;

namespace _21_TelefonRehberiUygulamasi
{
    public class Kisi
    {
        private string _name;
        private string _surname;
        private string _firstNumber;

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string FirstNumber 
        { 
            get
            {
                return numaraDonusturucu(_firstNumber); 
            }
            set
            {
                if(value.Length != 10 ){
                    throw new NotImplementedException("Eksik veya fazla numara girdiniz.");
                }else{
                    for(int i = 0; i < value.Length; i++){
                        if(!char.IsNumber(value, i)){
                            throw new NotImplementedException("Girilen numara değer numerik olmalıdır.");
                        }
                    }
                    _firstNumber = value;
                }
            }
        }
        public Kisi()
        {

        }
        public Kisi(string _name, string _surname, string _number){
            this.Name = _name;
            this.Surname = _surname;
            this.FirstNumber = _number;
        }
        public string numaraDonusturucu(string s){
            if(s.Length == 10){
                return string.Format("+90({0}){1}/{2}-{3}",s.Substring(0,3),s.Substring(3,3),
                                            s.Substring(6,2),s.Substring(8,2));
            }else{
                return "";
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}",Name,Surname,FirstNumber);
        }
    }
}