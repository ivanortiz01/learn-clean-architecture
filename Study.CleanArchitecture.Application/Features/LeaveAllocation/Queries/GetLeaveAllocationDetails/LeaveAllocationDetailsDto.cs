﻿using Study.CleanArchitecture.Application.Features.LeaveType.Queries.GetAllLeaveTypes;

namespace Study.CleanArchitecture.Application.Features.LeaveAllocation.Queries.GetLeaveAllocationDetails;

public class LeaveAllocationDetailsDto
{
    public int Id
    {
        get; set;
    }
    public int NumberOfDays
    {
        get; set;
    }
    public LeaveTypeDto LeaveType
    {
        get; set;
    }
    public int LeaveTypeId
    {
        get; set;
    }
    public int Period
    {
        get; set;
    }
}