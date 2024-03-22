using StudentService.Models;

namespace StudentService.DataAccess.Repository.IRepository
{
    public interface IStudentRepository: IRepository<Student>
    {
        void Update(Student obj);
    }
}
