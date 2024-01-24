using System;
using System.Collections.Generic;

namespace WpfAppDb.Models;

public partial class Employee
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int? DepartmentId { get; set; }
    public string? ImageUri { get; set; }
    public string? Position { get; set; }
    public virtual Department? Department { get; set; }
}
