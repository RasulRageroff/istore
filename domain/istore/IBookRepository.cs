using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using istore;


namespace istore
{
    public interface IBookRepository
    {

        Book[] GetAllByIsbn(string isbn);
        Book[] GetAllByTitleOrAuthor(string titleorAuthor);


    }
}
