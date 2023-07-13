using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Book
    {
        private string Book_ID;
        private string Author;
        private string Book_Name;
        private string Publisher;
        private string Edition;
        private int Year;
        private int Pice;
        private string Category;
        private string Sub_Category;
        private int Number_Of_Book;
        private string Description;
        private string Place;

        Book(string B_ID,string author,string B_Name,string pblisher,string edition,int yr,int price,string category,string sub_category,int noBook,string description,string place)
        {
            this.Book_ID = B_ID;
            this.Author = author;
            this.Book_Name = B_Name;
            this.Publisher = pblisher;
            this.Edition = edition;
            this.Year = yr;
            this.Pice = price;
            this.Category = category;
            this.Sub_Category = sub_category;
            this.Number_Of_Book = noBook;
            this.Description = description;
            this.Place = place;
        }

        public string Book_ID1 { get => Book_ID; set => Book_ID = value; }
        public string Author1 { get => Author; set => Author = value; }
        public string Book_Name1 { get => Book_Name; set => Book_Name = value; }
        public string Publisher1 { get => Publisher; set => Publisher = value; }
        public string Edition1 { get => Edition; set => Edition = value; }
        public int Year1 { get => Year; set => Year = value; }
        public int Pice1 { get => Pice; set => Pice = value; }
        public string Category1 { get => Category; set => Category = value; }
        public string Sub_Category1 { get => Sub_Category; set => Sub_Category = value; }
        public int Number_Of_Book1 { get => Number_Of_Book; set => Number_Of_Book = value; }
        public string Description1 { get => Description; set => Description = value; }
        public string Place1 { get => Place; set => Place = value; }
    }
}
