﻿using AutoMapper;
using MediatR;
using Study.CleanArchitecture.Application.Contracts.Persistence;

namespace Study.CleanArchitecture.Application.Features.LeaveAllocation.Queries.GetLeaveAllocations;

public class GetLeaveAllocationListHandler : IRequestHandler<GetLeaveAllocationListQuery, List<LeaveAllocationDto>>
{
    private readonly ILeaveAllocationRepository _leaveAllocationRepository;
    private readonly IMapper _mapper;

    public GetLeaveAllocationListHandler(ILeaveAllocationRepository leaveAllocationRepository,
         IMapper mapper)
    {
        _leaveAllocationRepository = leaveAllocationRepository;
        _mapper = mapper;
    }

    public async Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationListQuery request, CancellationToken cancellationToken)
    {
        // To Add later
        // - Get records for specific user
        // - Get allocations per employee

        var leaveAllocations = await _leaveAllocationRepository.GetLeaveAllocationsWithDetails();
        var allocations = _mapper.Map<List<LeaveAllocationDto>>(leaveAllocations);

        return allocations;
    }
}