using ShahzaibBooksStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShahzaibBooksStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();

        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();

        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1, Title = "Harry Potter", Author = "JK Rowling" },
                new BookModel() { Id = 2, Title = "Harry Potter 2", Author = "JK Rowling 2"},
                new BookModel() { Id = 3, Title = "Harry Potter 3", Author = "JK Rowling 3"},
                new BookModel() { Id = 4, Title = "Harry Potter 3", Author = "JK Rowling 4"},
            }; 
        }
    }
}
