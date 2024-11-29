using Microsoft.AspNetCore.Components;
using Study.CleanArchitecture.BlazorUI.Contracts;
using Study.CleanArchitecture.BlazorUI.Models.LeaveTypes;

namespace Study.CleanArchitecture.BlazorUI.Pages.LeaveTypes;

public partial class Details
{
    [Inject]
    ILeaveTypeService _client
    {
        get; set;
    }

    [Parameter]
    public int id
    {
        get; set;
    }

    LeaveTypeVM leaveType = new LeaveTypeVM();

    protected async override Task OnParametersSetAsync()
    {
        leaveType = await _client.GetLeaveTypeDetails(id);
    }
}