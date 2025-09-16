using istore;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {


        private readonly Book[] books = new[]
        {
            new Book(1,"ISBN 12312-31231","D. Knuth", "Art of Programming","мужчинская кнгига",7.19m),
            new Book(2,"ISBN 12312-31232","M. Fowler", "Refactoring","хуета", 5.55m),
            new Book(3,"ISBN 12312-31233","B. Kernighan, D. Ritchie", "C Programming Language","sorahanskiy", 13.37m),
        };

        public Book GetById(int id)
        {
            return books.Single(book => book.Id == id);
        }

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn).ToArray();
        }

        public Book[] GetAllByTitle(string titlePart)
        {
            return books.Where(book => book.Title.Contains(titlePart)).ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string titleorAuthor)
        {
            return books.Where(book => book.Author.Contains(titleorAuthor) || book.Title.Contains(titleorAuthor)).ToArray();
        }
    }
}
