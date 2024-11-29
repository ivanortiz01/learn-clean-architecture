using AutoMapper;
using MediatR;
using Study.CleanArchitecture.Application.Contracts.Persistence;
using Study.CleanArchitecture.Application.Exceptions;

namespace Study.CleanArchitecture.Application.Features.LeaveType.Queries.GetLeaveTypeDetails;

public class GetLeaveTypeDetailsQueryHandler : IRequestHandler<GetLeaveTypeDetailsQuery, LeaveTypeDetailsDto>
{
    private readonly IMapper _mapper;
    private readonly ILeaveTypeRepository _leaveTypeRepository;

    public GetLeaveTypeDetailsQueryHandler(
        IMapper mapper,
        ILeaveTypeRepository leaveTypeRepository
    )
    {
        this._mapper = mapper;
        this._leaveTypeRepository = leaveTypeRepository;
    }

    public async Task<LeaveTypeDetailsDto> Handle(GetLeaveTypeDetailsQuery request, CancellationToken cancellationToken)
    {
        // Query the database
        var leaveType = await _leaveTypeRepository.GetByIdAsync(request.Id);

        // Verify that record exists
        if (leaveType is null)
        {
            throw new NotFoundException(nameof(LeaveType), request.Id);
        }

        //Convert data objects to DTO objects
        var leaveTypeDetails = _mapper.Map<LeaveTypeDetailsDto>(leaveType);

        //return list of DTO object
        return leaveTypeDetails;
    }
}
