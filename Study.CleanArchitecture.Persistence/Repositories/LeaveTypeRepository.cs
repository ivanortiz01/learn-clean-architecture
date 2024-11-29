using Microsoft.EntityFrameworkCore;
using Study.CleanArchitecture.Application.Contracts.Persistence;
using Study.CleanArchitecture.Domain;
using Study.CleanArchitecture.Persistence.DatabaseContext;

namespace Study.CleanArchitecture.Persistence.Repositories;

public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
{
    public LeaveTypeRepository(HrDatabaseContext context) : base(context)
    {
    }

    public async Task<bool> IsLeaveTypeUnique(string name)
    {
        return await _context.LeaveTypes.AnyAsync(q => q.Name == name) is false;
    }
}
