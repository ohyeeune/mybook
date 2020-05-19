using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mybook
{
    class Program
    {
        class Book
        {
            public string name;
            public string firstBook;
            public string author;
            public string publisher;
            public string publish;
            public string Seditor;
            public string planner;
            public string editor;
            public string designer;
        }
        static void Main(string[] args)
        {
            Book book = new Book();
            book.name = "PHP 프로그래밍 입문";
            book.firstBook = "2013년 5월 20일";
            book.author = "황재호";
            book.publisher = "김태헌";
            book.publish = "한빛아카데미(주)";
            book.Seditor = "김현용";
            book.planner = "김이화";
            book.editor = "김이화";
            book.designer = "여동일";
        }
    }
}
