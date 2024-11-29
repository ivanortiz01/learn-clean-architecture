using MediatR;

namespace Study.CleanArchitecture.Application.Features.LeaveType.Commands.CreateLeaveType;

public class CreateLeaveTypeCommand : IRequest<int>
{
    public string Name { get; set; } = null!;

    public int DefaultDays { get; set; }
}
