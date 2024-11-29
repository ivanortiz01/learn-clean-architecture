using Study.CleanArchitecture.BlazorUI.Models.LeaveAllocations;

namespace Study.CleanArchitecture.BlazorUI.Models.LeaveRequests;

public class EmployeeLeaveRequestViewVM
{
    public List<LeaveAllocationVM> LeaveAllocations { get; set; } = new List<LeaveAllocationVM>();
    public List<LeaveRequestVM> LeaveRequests { get; set; } = new List<LeaveRequestVM>();
}
