using MediatR;

namespace Study.CleanArchitecture.Application.Features.LeaveAllocation.Commands.DeleteLeaveAllocation;

public class DeleteLeaveAllocationCommand : IRequest
{
    public int Id
    {
        get; set;
    }
}