using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp1
{
    class Book
    {
        public string title;
        public string author;
        public int pages;
        private int rating;
        public static int bookCount = 0;

        public Book()
        {

        }

        public Book(string title, string author, int pages, int rating)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            Rating = rating;
            bookCount++;
        }

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
            }
        }

        public int Rating
        {
            get { return rating; }
            set
            {
                if(value >= 0 && value <= 5)
                {
                    rating = value;
                }
                else
                {
                    throw new ArgumentException();
                    // rating = 0;
                }
            }
        }

        public string GetString()
        {
            return "Title: " + title + " Author: " + author + 
                " Pages: " + Convert.ToString(pages) + " Rating: " + Convert.ToString(Rating);
        }

    }
}
