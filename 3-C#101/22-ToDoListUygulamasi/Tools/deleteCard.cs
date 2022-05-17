using System;
using System.Collections.Generic;

namespace _22_ToDoListUygulamasi
{
    public static class DeleteCard
    {
        public static isComplate deleteCard(List<Card> cardList)
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor." +
                            "\nLütfen kart başlığını yazınız:  "); 
            string cardTitle = Console.ReadLine();
            string choose;
            int listCount = 0;
            List<Card> toBeDeleted = new List<Card>();
            foreach (var item in cardList)
            {
                if(cardTitle == item.Title){
                    Console.WriteLine(string.Format(
                        "{0} başlıklı kart bulundu. Silinmek üzere, emin misiniz? (y/n)",cardTitle
                    ));
                    choose = Console.ReadLine();
                    if(choose == "y" || choose == "Y"){
                        toBeDeleted.Add(item);
                        listCount++;
                    }
                }
            }
            if(listCount >= 1){
                foreach (var item in toBeDeleted)
                {
                    cardList.Remove(item);
                }
                return isComplate.Yes;
            }else{
                Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\n" +
                            "* İşlemi sonlandırmak için : (1)\n" +
                            "* Yeniden denemek için : (2)");        
                choose = Console.ReadLine();
                if(choose == "2"){
                    return deleteCard(cardList);
                }else
                    return isComplate.No;
            }
            
        }
    }
}