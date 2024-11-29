using Study.CleanArchitecture.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Study.CleanArchitecture.Domain;

public class LeaveType : BaseEntity
{
    public string Name { get; set; } = null!;

    public int DefaultDays { get; set; }
}
