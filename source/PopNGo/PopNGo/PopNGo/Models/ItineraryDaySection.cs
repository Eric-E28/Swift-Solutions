using PopNGo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ItineraryDaySection")]
public class ItineraryDaySection
{
    public int ID { get; set; }
    public string ItineraryTitle { get; set; }
    public DateTime ItineraryDate { get; set; }
    public virtual List<ItineraryChecklist> ItineraryChecklists { get; set; }
}
