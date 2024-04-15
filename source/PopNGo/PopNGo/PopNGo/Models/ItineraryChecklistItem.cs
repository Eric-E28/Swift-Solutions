using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ItineraryChecklistItem")]
public class ItineraryChecklistItem
{
    public int ID { get; set; }
    public int ItineraryChecklistId { get; set; }
    public string ItemDescription { get; set; }
    public virtual ItineraryChecklist ItineraryChecklist { get; set; }
}

