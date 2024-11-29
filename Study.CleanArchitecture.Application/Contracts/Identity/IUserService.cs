using Study.CleanArchitecture.Application.Models.Identity;

namespace Study.CleanArchitecture.Application.Contracts.Identity;

public interface IUserService
{
    Task<List<Employee>> GetEmployees();
    Task<Employee> GetEmployee(string userId);
    public string UserId
    {
        get;
    }
}