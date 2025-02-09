using System;
using System.Collections.Generic;

namespace ecommerce.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public int? Electronic { get; set; }

    public int? HomeLifeStationaryOffice { get; set; }

    public int? GardenAutoaccessory { get; set; }

    public int? MotherBabyToy { get; set; }

    public int? SportOutdoor { get; set; }

    public int? PersonalCare { get; set; }

    public int? SupermarketPetshop { get; set; }

    public int? BookMusicFilmHobby { get; set; }

    public int? Fashion { get; set; }
}
