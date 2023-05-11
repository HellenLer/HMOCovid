using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class DateVaccine
{
    public int VaccinesKey { get; set; }

    public int PersonId { get; set; }

    public DateTime VaccinesDate { get; set; }

    public int Company { get; set; }

    public virtual Company CompanyNavigation { get; set; } = null!;

    public virtual MembersDetail Person { get; set; } = null!;
}
