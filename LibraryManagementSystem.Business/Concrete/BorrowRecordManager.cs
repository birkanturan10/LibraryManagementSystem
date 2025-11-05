using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.DataAccess.Abstract;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Business.Concrete
{
    public class BorrowRecordManager : IBorrowRecordService
    {
        private readonly IBorrowRecordDal _borrowRecordDal;

        public BorrowRecordManager(IBorrowRecordDal borrowRecordDal)
        {
            _borrowRecordDal = borrowRecordDal;
        }

        public void Add(BorrowRecord record) => _borrowRecordDal.Add(record);
        public void Update(BorrowRecord record) => _borrowRecordDal.Update(record);
        public void Delete(BorrowRecord record) => _borrowRecordDal.Delete(record);
        public BorrowRecord GetById(int id) => _borrowRecordDal.Get(r => r.RecordID == id);
        public List<BorrowRecord> GetAll() => _borrowRecordDal.GetAll();
    }
}
