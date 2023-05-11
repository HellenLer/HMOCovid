using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Adress
{
    public int AdressKey { get; set; }

    public int City { get; set; }

    public int Street { get; set; }

    public int HouseNum { get; set; }

    public virtual City CityNavigation { get; set; } = null!;

    public virtual ICollection<MembersDetail> MembersDetails { get; set; } = new List<MembersDetail>();

    public virtual Street StreetNavigation { get; set; } = null!;
}
