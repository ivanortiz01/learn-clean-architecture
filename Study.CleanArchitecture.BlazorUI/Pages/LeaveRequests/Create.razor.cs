using Microsoft.AspNetCore.Components;
using Study.CleanArchitecture.BlazorUI.Contracts;
using Study.CleanArchitecture.BlazorUI.Models.LeaveRequests;
using Study.CleanArchitecture.BlazorUI.Models.LeaveTypes;

namespace Study.CleanArchitecture.BlazorUI.Pages.LeaveRequests;

public partial class Create
{
    [Inject]
    ILeaveTypeService leaveTypeService
    {
        get; set;
    }
    [Inject]
    ILeaveRequestService leaveRequestService
    {
        get; set;
    }
    [Inject]
    NavigationManager NavigationManager
    {
        get; set;
    }
    LeaveRequestVM LeaveRequest { get; set; } = new LeaveRequestVM();
    List<LeaveTypeVM> leaveTypeVMs { get; set; } = new List<LeaveTypeVM>();

    protected override async Task OnInitializedAsync()
    {
        leaveTypeVMs = await leaveTypeService.GetLeaveTypes();
    }

    private async Task HandleValidSubmit()
    {
        // Perform form submission here
        await leaveRequestService.CreateLeaveRequest(LeaveRequest);
        NavigationManager.NavigateTo("/leaverequests/");
    }
}