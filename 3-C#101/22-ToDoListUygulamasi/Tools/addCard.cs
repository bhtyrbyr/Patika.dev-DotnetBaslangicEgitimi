using System;
using System.Collections;
using System.Collections.Generic;

namespace _22_ToDoListUygulamasi
{
    public static class AddCard
    {
        public static isComplate addCard(List<Card> list, Dictionary<int, string> personalList)
        {
            byte  BoardID = 0;
            Console.WriteLine("Hangi Line'a kart eklemek istiyorsunuz ?\n1-)ToDo Line \n2-)In Progress Line \n3-)Done Line");
            string select = Console.ReadLine();
            switch(select)
            {
                case "1" : BoardID = 1; break;
                case "2" : BoardID = 2; break;
                case "3" : BoardID = 3; break;
                default :
                {
                    Console.WriteLine("Hatalı seçim yaptınız!. Tekrar deneyin!");
                    return addCard(list, personalList);
                }
            }
            try
            {
                Card newCard = new Card();
                newCard.BoardID = BoardID;
                newCard.CardID = createCardID(list);
                Console.WriteLine(" Başlık Giriniz                                  :"); 
                newCard.Title = Console.ReadLine();
                Console.WriteLine(" İçerik Giriniz                                  :");
                newCard.Description = Console.ReadLine();;
                Console.WriteLine(" Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
                byte Sze = byte.Parse(Console.ReadLine());
                
                    string i = "coderbyte";
                    i.Length
                switch (Sze)
                {
                    
                    case 1 : newCard.Size = CardSize.XS; break;
                    case 2 : newCard.Size = CardSize.S; break;
                    case 3 : newCard.Size = CardSize.M; break;
                    case 4 : newCard.Size = CardSize.L; break;
                    case 5 : newCard.Size = CardSize.XL; break;
                    default: 
                    {
                        throw new Exception("Kart boyutunu yanlış girdiniz !");
                        
                    }
                }
                int perID = 0;
                for (int i = 0; i < Sze; i++)
                {
                    Console.WriteLine(" Kişi Seçiniz                                    :");
                    Console.WriteLine(" (Kişi eklemek için ID girişi yapmanız gerekir. Personelleri ID'leri :\n" +
                                    " 1 - 111 Isac\t\t4 - 444 Jhon\n" +
                                    " 2 - 222 July\t\t5 - 555 Toby\n" +
                                    " 3 - 333 Katrina\t6 - 666 Alexandra" 
                                    ); 
                    perID = int.Parse(Console.ReadLine());
                    if(personalList.ContainsKey(perID)){
                        newCard.personalAdd(perID);
                    }else{
                        Console.WriteLine("Girilen personel ID bulunamadı.\nTekrar deneyin!");
                        i--;
                    }
                }
                list.Add(newCard);
                return isComplate.Yes;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return isComplate.No;
            }
        } 

        private static int createCardID(List<Card> list)
        {
            List<int> IDs = new List<int>();
            foreach (var item in list)
            {
                IDs.Add(item.CardID);
            }
            IDs.Sort(); IDs.Reverse();
            return IDs[0] + 1;
        }
    }
}