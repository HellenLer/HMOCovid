using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class MembersDetail
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    public int Address { get; set; }

    public string? Phone { get; set; }

    public string MobilePhone { get; set; } = null!;

    public virtual Adress AddressNavigation { get; set; } = null!;

    public virtual ICollection<DateVaccine> DateVaccines { get; set; } = new List<DateVaccine>();

    public virtual SickDate? SickDate { get; set; }
}
