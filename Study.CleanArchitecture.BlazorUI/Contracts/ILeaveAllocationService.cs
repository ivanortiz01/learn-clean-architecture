using Study.CleanArchitecture.BlazorUI.Services.Base;

namespace Study.CleanArchitecture.BlazorUI.Contracts;

public interface ILeaveAllocationService
{
    Task<Response<Guid>> CreateLeaveAllocations(int leaveTypeId);
}