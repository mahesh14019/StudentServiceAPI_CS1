using StudentService.DataAccess.Data;
using StudentService.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentService.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private StudentDbContext _db;

        public UnitOfWork(StudentDbContext db)
        {
            _db = db;
            Students = new StudentRepository(_db);
            Courses = new CourseRepository(_db);
        }

        public IStudentRepository Students { get; private set; }
        public ICourseRepository Courses { get; private set; }
        public void Save()
        {
            _db.SaveChanges();
        }
        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
