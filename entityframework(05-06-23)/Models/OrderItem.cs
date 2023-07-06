using System;
using System.Collections.Generic;

namespace entityframework_05_06_23_.Models;

public partial class OrderItem
{
    public int ItemId { get; set; }

    public int OrderId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public int? ListPrice { get; set; }

    public decimal? Discount { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Product? Product { get; set; }
}
