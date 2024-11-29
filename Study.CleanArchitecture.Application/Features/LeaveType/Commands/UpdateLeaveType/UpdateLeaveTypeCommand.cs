using MediatR;

namespace Study.CleanArchitecture.Application.Features.LeaveType.Commands.UpdateLeaveType;

public class UpdateLeaveTypeCommand : IRequest<Unit>
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int DefaultDays { get; set; }
}
