
namespace StudentService.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IStudentRepository Students { get; }
        ICourseRepository Courses { get; }
        void Save();
        Task SaveAsync();
    }
}
