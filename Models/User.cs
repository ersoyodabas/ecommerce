using System;
using System.Collections.Generic;

namespace ecommerce.Models;

public partial class User
{
    public long Id { get; set; }

    public DateTime CreateTime { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string? Tckn { get; set; }

    public string? Vkn { get; set; }

    public string PhoneArea { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }
}
