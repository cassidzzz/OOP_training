using System;
using System.Collections.Generic;
using System.Text;

namespace Ch1.Tasks
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        private double Price;
        private int pages;
        public double price 
        { 
            get { return Price; }
            set { Price = value; }
        }
        public int Pages
        {
            get { return pages; }
            set { pages = value > 0 ? value : 1; }
        }

    public Book(string title, string author, int pages, double price_)
        {
            Title = title;
            Author = author;
            Pages = pages;
            Price = price_;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Название: " + Title);
            Console.WriteLine("Автор: " + Author);
            Console.WriteLine("Страниц: " + Pages);
            Console.WriteLine("Цена: " + Price);
        }
    }
}
