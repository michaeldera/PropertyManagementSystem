using PropertyManagementSystem.Common.Models;
using System.Threading.Tasks;

namespace PropertyManagementSystem.ProviderLogic.Interfaces
{
    partial interface IStudentLeasseeLogic
    {
        Task<StudentLessee> CreateAsync(StudentLessee studentLessee);
        Task<StudentLessee> RetrieveByIdAsync(int id);
        Task<StudentLessee> UpdateAsync(int id, StudentLessee studentLessee);
        Task<StudentLessee> DeleteByIdAsync(int id);
        Task<bool> StudentLesseeExists(int id);
    }
}
