using LibraryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Abstract
{
    public interface IBorrowRecordService
    {
        void Add(BorrowRecord record);
        void Update(BorrowRecord record);
        void Delete(BorrowRecord record);
        BorrowRecord GetById(int id);
        List<BorrowRecord> GetAll();
    }
}
