using Study.CleanArchitecture.Domain;

namespace Study.CleanArchitecture.Application.Contracts.Persistence;

public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
{
    Task<bool> IsLeaveTypeUnique(string name);
}
