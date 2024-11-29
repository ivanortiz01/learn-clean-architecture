using Study.CleanArchitecture.BlazorUI.Models.LeaveTypes;
using Study.CleanArchitecture.BlazorUI.Services.Base;

namespace Study.CleanArchitecture.BlazorUI.Contracts;

public interface ILeaveTypeService
{
    Task<List<LeaveTypeVM>> GetLeaveTypes();
    Task<LeaveTypeVM> GetLeaveTypeDetails(int id);
    Task<Response<Guid>> CreateLeaveType(LeaveTypeVM leaveType);
    Task<Response<Guid>> UpdateLeaveType(int id, LeaveTypeVM leaveType);
    Task<Response<Guid>> DeleteLeaveType(int id);
}