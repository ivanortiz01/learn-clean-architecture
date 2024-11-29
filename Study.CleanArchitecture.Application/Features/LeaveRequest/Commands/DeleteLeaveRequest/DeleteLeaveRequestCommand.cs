using MediatR;

namespace Study.CleanArchitecture.Application.Features.LeaveRequest.Commands.DeleteLeaveRequest;

public class DeleteLeaveRequestCommand : IRequest
{
    public int Id
    {
        get; set;
    }
}
