using LibraryManagementSystem.DataAccess.Abstract;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.DataAccess.Concrete.EntityFramework
{
    public class EfMemberDal : EfRepositoryBase<Member>, IMemberDal { }
}
