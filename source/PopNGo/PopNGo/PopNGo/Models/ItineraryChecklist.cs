using PopNGo.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ItineraryChecklist")]
public class ItineraryChecklist
{
    public int ID { get; set; }
    public int ItineraryDaySectionId { get; set; }
    public string ItineraryHeader { get; set; }
    public virtual ItineraryDaySection ItineraryDaySection { get; set; }
    public virtual List<ItineraryChecklistItem> ItineraryChecklistItems { get; set; }
}
