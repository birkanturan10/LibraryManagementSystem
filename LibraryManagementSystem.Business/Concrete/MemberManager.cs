using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.DataAccess.Abstract;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Business.Concrete
{
    public class MemberManager : IMemberService
    {
        private readonly IMemberDal _memberDal;

        public MemberManager(IMemberDal memberDal)
        {
            _memberDal = memberDal;
        }

        public void Add(Member member) => _memberDal.Add(member);
        public void Update(Member member) => _memberDal.Update(member);
        public void Delete(Member member) => _memberDal.Delete(member);
        public Member GetById(int id) => _memberDal.Get(m => m.MemberID == id);
        public List<Member> GetAll() => _memberDal.GetAll();
    }
}
