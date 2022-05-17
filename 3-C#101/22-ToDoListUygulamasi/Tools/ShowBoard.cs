using System;
using System.Collections.Generic;

namespace _22_ToDoListUygulamasi
{
    public static class ShowBoard
    {
        static List<Card> ToDoList = new();
        static List<Card> InProgressList = new();
        static List<Card> DoneList  = new();
        public static isComplate showBoard(List<Card> lines, Dictionary<int, string> perList)
        {
            if(lines.Count == 1)
            {
                Console.WriteLine("Line'lar tamamen boştur. Görüntülemek için yeni kartlar ekleyin.!");
                return isComplate.Yes;
            }
            searchList(lines);
            Console.WriteLine(" TODO Line\n" +
                            "************************");  
            fillLine(1, ToDoList, perList);   
            Console.WriteLine(" IN PROGRESS Line\n" +
                            "************************");  
            fillLine(2, InProgressList, perList);   
            Console.WriteLine(" DONE Line\n" +
                            "************************");  
            fillLine(3, DoneList, perList);   
            return isComplate.Yes;
        }

        private static void searchList(List<Card> liness)
        {
            ToDoList.Clear();
            InProgressList.Clear();
            DoneList.Clear();
            foreach (var item in liness)
            {
                switch(item.BoardID){
                    case 1 : ToDoList.Add(item); break;
                    case 2 : InProgressList.Add(item); break;
                    case 3 : DoneList.Add(item); break;
                    default : break;
                }
            }
        }

        private static void fillLine(byte lineNum, List<Card> lines, Dictionary<int, string> perList)
        {
            foreach (var item in lines)
            {
                string perNameText = getPersonalName(item.Personal,perList);
                Console.WriteLine(string.Format(
                    " Başlık      : {0}\n" +
                    " İçerik      : {1}\n" +
                    " Atanan Kişi : {2}\n" +
                    " Büyüklük    : {3}",item.Title,item.Description,perNameText,item.Size.ToString()
                ));
                Console.WriteLine("\n-----------------------\n");
            }
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