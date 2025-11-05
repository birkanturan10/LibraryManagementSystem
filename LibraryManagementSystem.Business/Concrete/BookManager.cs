using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.DataAccess.Abstract;
using LibraryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Concrete
{
    public class BookManager:IBookService
    {
        private readonly IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void Add(Book book) => _bookDal.Add(book);
        public void Update(Book book) => _bookDal.Update(book);
        public void Delete(Book book) => _bookDal.Delete(book);
        public Book GetById(int id) => _bookDal.Get(b => b.BookID == id);
        public List<Book> GetAll() => _bookDal.GetAll();
    }
}
