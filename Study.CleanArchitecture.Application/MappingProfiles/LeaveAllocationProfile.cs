using AutoMapper;
using Study.CleanArchitecture.Application.Features.LeaveAllocation.Commands.CreateLeaveAllocation;
using Study.CleanArchitecture.Application.Features.LeaveAllocation.Commands.UpdateLeaveAllocation;
using Study.CleanArchitecture.Application.Features.LeaveAllocation.Queries.GetLeaveAllocationDetails;
using Study.CleanArchitecture.Application.Features.LeaveAllocation.Queries.GetLeaveAllocations;
using Study.CleanArchitecture.Domain;

namespace Study.CleanArchitecture.Application.MappingProfiles;

public class LeaveAllocationProfile : Profile
{
    public LeaveAllocationProfile()
    {
        CreateMap<LeaveAllocationDto, LeaveAllocation>().ReverseMap();
        CreateMap<LeaveAllocation, LeaveAllocationDetailsDto>();
        CreateMap<CreateLeaveAllocationCommand, LeaveAllocation>();
        CreateMap<UpdateLeaveAllocationCommand, LeaveAllocation>();
    }
}
