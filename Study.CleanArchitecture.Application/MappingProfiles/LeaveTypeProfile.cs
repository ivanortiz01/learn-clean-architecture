using AutoMapper;
using Study.CleanArchitecture.Application.Features.LeaveType.Queries.GetAllLeaveTypes;
using Study.CleanArchitecture.Application.Features.LeaveType.Queries.GetLeaveTypeDetails;
using Study.CleanArchitecture.Domain;

namespace Study.CleanArchitecture.Application.MappingProfiles;

public class LeaveTypeProfile : Profile
{
    public LeaveTypeProfile()
    {
        CreateMap<LeaveTypeDto, LeaveType>()
            .ReverseMap();

        CreateMap<LeaveType, LeaveTypeDetailsDto>();
    }
}
