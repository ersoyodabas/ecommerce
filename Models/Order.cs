using System;
using System.Collections.Generic;

namespace ecommerce.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int UserId { get; set; }

    public decimal TotalAmount { get; set; }

    public string PaymentStatus { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public string DeliveryAdress { get; set; } = null!;

    public string OrderStatus { get; set; } = null!;

    public DateTime PaymentDate { get; set; }

    public DateTime UploadDate { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }
}
