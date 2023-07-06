using System;
using System.Collections.Generic;

namespace task_05_06_23_employeefullname.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Fullname { get { return Firstname + " " + Lastname; }set { } }
}
