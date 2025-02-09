using System;
using System.Collections.Generic;

namespace ecommerce.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }

    public int CategoryId { get; set; }

    public int TrademarkId { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}
