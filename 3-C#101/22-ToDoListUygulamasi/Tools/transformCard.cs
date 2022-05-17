using System;
using System.Collections.Generic;

namespace _22_ToDoListUygulamasi
{
    public static class TransformCard
    {
        public static isComplate transformCard(List<Card> cardList, Dictionary<int, string> perList)
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor." +
                            "\nLütfen kart başlığını yazınız:  "); 

            string cardTitle = Console.ReadLine();
            string perName = "";
            string cardLine = "";
            string choose = "";

            foreach (var item in cardList)
            {
                if(cardTitle == item.Title){
                    perName = getPersonalName(item.Personal, perList);
                    switch(item.BoardID)
                    {
                        case 1 : cardLine = "ToDo Line"; break;
                        case 2 : cardLine = "In Progress Line"; break;
                        case 3 : cardLine = "Done Line"; break;
                        default : break;
                    }
                    Console.WriteLine(string.Format(
                        " Bulunan Kart Bilgileri:\n" +
                        "  **************************************\n" +
                        "  Başlık      :{0}\n" +
                        "  İçerik      :{1}\n" +
                        "  Atanan Kişi :{2}\n" +
                        "  Büyüklük    :{3}\n" +
                        "  Line        :{4}\n" +
                        "\n" +
                        "  Lütfen taşımak istediğiniz Line'ı seçiniz: \n" +
                        "  (1) TODO\n" +
                        "  (2) IN PROGRESS\n" +
                        "  (3) DONE",item.Title,item.Description,perName,item.Size.ToString(),cardLine
                    ));
                    choose = Console.ReadLine();
                    try
                    {
                        switch(choose)
                        {
                            case "1" : item.BoardID = 1; break;
                            case "2" : item.BoardID = 2; break;
                            case "3" : item.BoardID = 3; break;
                            default : throw new Exception("Hatalı seçim yapıldı. Taşıma işlemi iptal edildi.!");
                        }
                    }
                    catch (System.Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    return isComplate.No;
                    }
                    return isComplate.Yes;
                }
            }
            Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\n" +
                            "* İşlemi sonlandırmak için : (1)\n" +
                            "* Yeniden denemek için : (2)");        
            choose = Console.ReadLine();
            if(choose == "2"){
                return transformCard(cardList, perList);
            }else
                return isComplate.No;

        }

        private static string getPersonalName(List<int> personal, Dictionary<int, string> perList)
        {
            string nameText = "\n";
            foreach (var item in personal)
            {
                nameText += perList[item] + "\n";
            }
            return nameText;
        }
    }
}