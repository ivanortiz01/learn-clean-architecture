using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Study.CleanArchitecture.BlazorUI.Contracts;
using Study.CleanArchitecture.BlazorUI.Models.LeaveTypes;

namespace Study.CleanArchitecture.BlazorUI.Pages.LeaveTypes;

public partial class Index
{
    [Inject]
    public NavigationManager NavigationManager
    {
        get; set;
    }

    [Inject]
    public ILeaveTypeService LeaveTypeService
    {
        get; set;
    }
    [Inject]
    public ILeaveAllocationService LeaveAllocationService
    {
        get; set;
    }
    [Inject]
    IToastService toastService
    {
        get; set;
    }
    public List<LeaveTypeVM> LeaveTypes
    {
        get; private set;
    }
    public string Message { get; set; } = string.Empty;

    protected void CreateLeaveType()
    {
        NavigationManager.NavigateTo("/leavetypes/create/");
    }

    protected void AllocateLeaveType(int id)
    {
        // Use Leave Allocation Service here
        LeaveAllocationService.CreateLeaveAllocations(id);
    }

    protected void EditLeaveType(int id)
    {
        NavigationManager.NavigateTo($"/leavetypes/edit/{id}");
    }

    protected void DetailsLeaveType(int id)
    {
        NavigationManager.NavigateTo($"/leavetypes/details/{id}");
    }

    protected async Task DeleteLeaveType(int id)
    {
        var response = await LeaveTypeService.DeleteLeaveType(id);
        if (response.Success)
        {
            toastService.ShowSuccess("Leave Type deleted Successfully");
            await OnInitializedAsync();
        }
        else
        {
            Message = response.Message;
        }
    }

    protected override async Task OnInitializedAsync()
    {
        LeaveTypes = await LeaveTypeService.GetLeaveTypes();
    }
}