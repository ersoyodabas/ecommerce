using System;
using System.Collections.Generic;

namespace ecommerce.Models;

public partial class category
{
    public int category_id { get; set; }

    public DateTime create_date { get; set; }

    public DateTime update_date { get; set; }

    public int? electronic { get; set; }

    public int? home_life_stationary_office { get; set; }

    public int? garden_autoaccessory { get; set; }

    public int? mother_baby_toy { get; set; }

    public int? sport_outdoor { get; set; }

    public int? personal_care { get; set; }

    public int? supermarket_petshop { get; set; }

    public int? book_music_film_hobby { get; set; }

    public int? fashion { get; set; }
}
