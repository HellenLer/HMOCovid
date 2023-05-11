using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Company
{
    public int CompanyKey { get; set; }

    public string CompanyName { get; set; } = null!;

    public virtual ICollection<DateVaccine> DateVaccines { get; set; } = new List<DateVaccine>();
}
