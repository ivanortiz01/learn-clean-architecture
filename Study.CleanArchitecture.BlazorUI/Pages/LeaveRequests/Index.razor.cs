using Microsoft.AspNetCore.Components;
using Study.CleanArchitecture.BlazorUI.Contracts;
using Study.CleanArchitecture.BlazorUI.Models.LeaveRequests;

namespace Study.CleanArchitecture.BlazorUI.Pages.LeaveRequests;

public partial class Index
{
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
    public AdminLeaveRequestViewVM Model { get; set; } = new();

    protected async override Task OnInitializedAsync()
    {
        Model = await leaveRequestService.GetAdminLeaveRequestList();
    }

    void GoToDetails(int id)
    {
        NavigationManager.NavigateTo($"/leaverequests/details/{id}");
    }
}