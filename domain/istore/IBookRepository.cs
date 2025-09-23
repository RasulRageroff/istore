
namespace istore
{
    public interface IBookRepository
    {
        Book[] GetAllByIds(IEnumerable<int> bookIds);
        Book[] GetAllByIsbn(string isbn);
        Book[] GetAllByTitleOrAuthor(string titleorAuthor);

        Book GetById(int id);
    }
}
