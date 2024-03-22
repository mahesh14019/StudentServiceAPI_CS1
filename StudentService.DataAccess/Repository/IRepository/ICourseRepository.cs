using StudentService.Models;

namespace StudentService.DataAccess.Repository.IRepository
{
    public interface ICourseRepository: IRepository<Course>
    {
        void Update(Course obj);
    }
}
