using System;
using System.Collections.Generic;

namespace Customer_06_06_23_entity_loan_.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? Cusname { get; set; }

    public string? Address { get; set; }

    public DateTime? LoanStartdate { get; set; }

    public DateTime? LoanDuedate { get; set; }

    public decimal? Principle { get; set; }

    public decimal? RateOfInterest { get; set; }

    public int? NoOfYears { get; set; }

    public decimal? CalculatedAmount { get; set; }
}
