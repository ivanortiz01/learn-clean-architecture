using MediatR;
using Study.CleanArchitecture.Application.Features.LeaveRequest.Shared;

namespace Study.CleanArchitecture.Application.Features.LeaveRequest.Commands.CreateLeaveRequest;

public class CreateLeaveRequestCommand : BaseLeaveRequest, IRequest<Unit>
{
    public string RequestComments { get; set; } = string.Empty;
}