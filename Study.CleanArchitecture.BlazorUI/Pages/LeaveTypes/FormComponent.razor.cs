using Microsoft.AspNetCore.Components;
using Study.CleanArchitecture.BlazorUI.Models.LeaveTypes;

namespace Study.CleanArchitecture.BlazorUI.Pages.LeaveTypes;

public partial class FormComponent
{
    [Parameter] public bool Disabled { get; set; } = false;
    [Parameter]
    public LeaveTypeVM LeaveType
    {
        get; set;
    }
    [Parameter] public string ButtonText { get; set; } = "Save";
    [Parameter]
    public EventCallback OnValidSubmit
    {
        get; set;
    }
}