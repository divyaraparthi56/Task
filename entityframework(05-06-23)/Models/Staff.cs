using System;
using System.Collections.Generic;

namespace entityframework_05_06_23_.Models;

public partial class Staff
{
    public int StaffId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public int? Phone { get; set; }

    public bool? Active { get; set; }

    public int? StoreId { get; set; }

    public int? ManagerId { get; set; }

    public virtual ICollection<Staff> InverseManager { get; set; } = new List<Staff>();

    public virtual Staff? Manager { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
