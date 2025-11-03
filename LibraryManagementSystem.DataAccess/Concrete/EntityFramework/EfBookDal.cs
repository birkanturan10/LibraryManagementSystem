using LibraryManagementSystem.DataAccess.Abstract;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : EfRepositoryBase<Book>, IBookDal { }
}
