﻿using MediatR;

namespace Study.CleanArchitecture.Application.Features.LeaveRequest.Queries.GetLeaveRequestList;

public class GetLeaveRequestListQuery : IRequest<List<LeaveRequestListDto>>
{
    public bool IsLoggedInUser
    {
        get; set;
    }
}