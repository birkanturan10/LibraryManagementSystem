using LibraryManagementSystem.DataAccess.Abstract;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.DataAccess.Concrete.EntityFramework
{
    public class EfBorrowRecordDal : EfRepositoryBase<BorrowRecord>, IBorrowRecordDal { }
}
