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
    
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private StudentDbContext _db;

        public CourseRepository(StudentDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Course obj)
        {
            var objFromDb = _db.Courses?.FirstOrDefault(u => u.CourseId == obj.CourseId);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
            }
        }
    }
}
