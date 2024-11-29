using AutoMapper;
using MediatR;
using Study.CleanArchitecture.Application.Contracts.Logging;
using Study.CleanArchitecture.Application.Contracts.Persistence;

namespace Study.CleanArchitecture.Application.Features.LeaveType.Queries.GetAllLeaveTypes;

public class GetLeaveTypesQueryHandler : IRequestHandler<GetLeaveTypesQuery, List<LeaveTypeDto>>
{
    private readonly IMapper _mapper;
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    public IAppLogger<GetLeaveTypesQueryHandler> _logger;

    public GetLeaveTypesQueryHandler(
        IMapper mapper,
        ILeaveTypeRepository leaveTypeRepository,
        IAppLogger<GetLeaveTypesQueryHandler> logger
    )
    {
        this._mapper = mapper;
        this._leaveTypeRepository = leaveTypeRepository;
        _logger = logger;
    }

    public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypesQuery request, CancellationToken cancellationToken)
    {
        // Query the database
        var leaveTypes = await _leaveTypeRepository.GetAsync();

        //Convert data objects to DTO objects
        var leaveTypeDtos =  _mapper.Map<List<LeaveTypeDto>>(leaveTypes);

        //return list of DTO object
        _logger.LogInformation("Leave types were retrieved successfully");
        return leaveTypeDtos;
    }
}
