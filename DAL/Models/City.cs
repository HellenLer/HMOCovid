using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class City
{
    public int CityKey { get; set; }

    public string City1 { get; set; } = null!;

    public virtual ICollection<Adress> Adresses { get; set; } = new List<Adress>();
}
