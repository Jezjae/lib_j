using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_j.model
{
    [Serializable]
    public class Book
    {
        private static Book BookInstance = null;

        public static Book Instance               //싱글톤 패턴으로 선언
        {
            get
            {
                if (BookInstance == null)
                    BookInstance = new Book();
                return BookInstance;
            }
        }

        private string id;
        private string title;
        private string writer;
        private string publisher;
        private int price;
        private int quantity;

        public Book()
        {

        }

        public Book(string id, string title, string writer, string publisher, int price, int quantity)
        {
            this.id = id;
            this.title = title;
            this.writer = writer;
            this.publisher = publisher;
            this.price = price;
            this.quantity = quantity;
        }

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Title
        {
            get{ return this.title; }
            set { this.title = value; }
        }

        public string Writer
        {
            get { return this.writer; }
            set { this.writer = value; }
        }

        public string Publisher
        {
            get { return this.publisher; }
            set { this.publisher = value; }
        }

        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
    }
}
