using System;
using System.Collections.Generic;

namespace _22_ToDoListUygulamasi
{
    public class Card
    {
        private int cardID;
        private byte boardID;
        private string title;
        private string description;
        private CardSize size = CardSize.XS;
        private List<int> personal = new List<int>();

        public int CardID{ get => cardID; set => cardID = value; }
        public byte BoardID { get => boardID; set => boardID = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public CardSize Size { get => size; set => size = value; }
        public List<int> Personal { get => personal; }

        public void personalAdd(int personID)
        {
            if(personal.Count < (byte)size) {
                personal.Add(personID);
            }else{
                throw new Exception("Kart boyutundan fazla personele atanamaz!");
            }
        }

    }
}