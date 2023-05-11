using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SickDate
{
    public int PersonId { get; set; }

    public DateTime SickDate1 { get; set; }

    public DateTime? RecoverDate { get; set; }

    public virtual MembersDetail Person { get; set; } = null!;
}
