using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblia
{
    public class Book
    {
        public int BookId { get; private set; }// id книги получем снаружи класса, но установить значение внутри
        public string Title { get; private set; }// название книги получем снаружи класса, но установить значение внутри

        public Book(int bookId, string title)//начало конструктора, с инициализацией свойств
        {//
            BookId = bookId;//
            Title = title;//
        }

        public override string ToString()//возвращение строкогого представления объекта
        {
            return $"{Title}";//создание строки тайтл(св-во)
        }
    }
}
