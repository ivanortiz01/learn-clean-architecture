using MediatR;

namespace Study.CleanArchitecture.Application.Features.LeaveRequest.Commands.CancelLeaveRequest;

public class CancelLeaveRequestCommand : IRequest<Unit>
{
    public int Id
    {
        get; set;
    }
}