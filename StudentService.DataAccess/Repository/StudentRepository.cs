using StudentService.DataAccess.Data;
using StudentService.DataAccess.Repository.IRepository;
using StudentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentService.DataAccess.Repository
{
    
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private StudentDbContext _db;

        public StudentRepository(StudentDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Student obj)
        {
            var objFromDb = _db.Students?.FirstOrDefault(u => u.StudentId== obj.StudentId);
            if (objFromDb != null)
            {
                objFromDb.PercentageMarks = obj.PercentageMarks;
                objFromDb.Mob = obj.Mob;
                objFromDb.CollegeName = obj.CollegeName;
                objFromDb.SName = obj.SName;
                objFromDb.RollNo = obj.RollNo;
            }
        }
    }
}
