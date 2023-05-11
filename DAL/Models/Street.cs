using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Street
{
    public int StreetKey { get; set; }

    public string NaneStreet { get; set; } = null!;

    public virtual ICollection<Adress> Adresses { get; set; } = new List<Adress>();
}
