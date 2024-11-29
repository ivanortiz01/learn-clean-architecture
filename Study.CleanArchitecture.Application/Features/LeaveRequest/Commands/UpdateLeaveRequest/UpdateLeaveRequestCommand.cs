using MediatR;
using Study.CleanArchitecture.Application.Features.LeaveRequest.Shared;

namespace Study.CleanArchitecture.Application.Features.LeaveRequest.Commands.UpdateLeaveRequest;

public class UpdateLeaveRequestCommand : BaseLeaveRequest, IRequest<Unit>
{
    public int Id
    {
        get; set;
    }
    public string RequestComments { get; set; } = string.Empty;
    public bool Cancelled
    {
        get; set;
    }
}