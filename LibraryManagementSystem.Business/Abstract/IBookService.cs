using LibraryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Abstract
{
    public interface IBookService
    {
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book);
        Book GetById(int id);
        List<Book> GetAll();   
    }
}
