using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Calendario
{
    public DateTime CalendarDate { get; set; }

    public int? CalendarCa { get; set; }

    public int? CalendarCd { get; set; }

    public int? WeekDayId { get; set; }

    public string? WeekDayName { get; set; }
}
