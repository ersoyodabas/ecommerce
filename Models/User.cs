using System;
using System.Collections.Generic;

namespace ecommerce.Models;

public partial class user
{
    public long id { get; set; }

    public DateTime create_time { get; set; }

    public string name { get; set; } = null!;

    public string surname { get; set; } = null!;

    public string gender { get; set; } = null!;

    public string? tckn { get; set; }

    public string? vkn { get; set; }

    public string phone_area { get; set; } = null!;

    public string phone_number { get; set; } = null!;

    public DateTime? update_date { get; set; }
}
