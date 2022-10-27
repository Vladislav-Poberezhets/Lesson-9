using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    class Book
    {
        string color;
        int pages;
        string author;
        string genre;
        public Book()
        {

        }
        public Book(string color, int pages, string author, string genre)
        {
            this.color = color;
            this.pages = pages;
            this.author = author;
            this.genre = genre; 
        }
    }
}
