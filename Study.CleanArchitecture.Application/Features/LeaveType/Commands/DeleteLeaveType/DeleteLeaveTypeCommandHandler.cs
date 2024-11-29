using MediatR;
using Study.CleanArchitecture.Application.Contracts.Persistence;
using Study.CleanArchitecture.Application.Exceptions;

namespace Study.CleanArchitecture.Application.Features.LeaveType.Commands.DeleteLeaveType;

public class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveTypeCommand, Unit>
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;

    public DeleteLeaveTypeCommandHandler(
        ILeaveTypeRepository leaveTypeRepository
    )
    {
        this._leaveTypeRepository = leaveTypeRepository;
    }

    public async Task<Unit> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        // Retrieve domain entity object
        var leaveTypeToDelete = await _leaveTypeRepository.GetByIdAsync(request.Id);

        // Verify that record exists
        if (leaveTypeToDelete is null)
        {
            throw new NotFoundException(nameof(LeaveType), request.Id);
        }

        // Remove from database
        await _leaveTypeRepository.DeleteAsync(leaveTypeToDelete);

        // Return unit value
        return Unit.Value;
    }
}
