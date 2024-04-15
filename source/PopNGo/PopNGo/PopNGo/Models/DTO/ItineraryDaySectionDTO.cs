using PopNGo.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PopNGo.Models.DTO
{
    public class ItineraryDaySectionDTO
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string ItineraryTitle { get; set; }

        [DataType(DataType.Date)]
        public DateTime ItineraryDate { get; set; }

        public List<ItineraryChecklistDTO> ItineraryChecklists { get; set; }
    }

    public class ItineraryChecklistDTO
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int ItineraryDaySectionId { get; set; }

        [Required]
        [StringLength(255)]
        public string ItineraryHeader { get; set; }

        public List<ItineraryChecklistItemDTO> ItineraryChecklistItems { get; set; }
    }

    public class ItineraryChecklistItemDTO
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int ItineraryChecklistId { get; set; }

        [Required]
        [StringLength(255)]
        public string ItemDescription { get; set; }
    }
}


namespace PopNGo.Extensions
{
    public static class ItineraryExtensions
    {
        public static ItineraryDaySectionDTO ToDTO(this ItineraryDaySection section)
        {
            return new ItineraryDaySectionDTO
            {
                ID = section.ID,
                ItineraryTitle = section.ItineraryTitle,
                ItineraryDate = section.ItineraryDate,
                ItineraryChecklists = section.ItineraryChecklists?.Select(cl => cl.ToDTO()).ToList()
            };
        }

        public static ItineraryChecklistDTO ToDTO(this ItineraryChecklist checklist)
        {
            return new ItineraryChecklistDTO
            {
                ID = checklist.ID,
                ItineraryDaySectionId = checklist.ItineraryDaySectionId,
                ItineraryHeader = checklist.ItineraryHeader,
                ItineraryChecklistItems = checklist.ItineraryChecklistItems?.Select(i => i.ToDTO()).ToList()
            };
        }

        public static ItineraryChecklistItemDTO ToDTO(this ItineraryChecklistItem item)
        {
            return new ItineraryChecklistItemDTO
            {
                ID = item.ID,
                ItineraryChecklistId = item.ItineraryChecklistId,
                ItemDescription = item.ItemDescription
            };
        }

        public static ItineraryDaySection ToItineraryDaySection(this ItineraryDaySectionDTO dto)
        {
            return new ItineraryDaySection
            {
                ID = dto.ID,
                ItineraryTitle = dto.ItineraryTitle,
                ItineraryDate = dto.ItineraryDate,
                ItineraryChecklists = dto.ItineraryChecklists?.Select(cl => cl.ToItineraryChecklist()).ToList()
            };
        }

        public static ItineraryChecklist ToItineraryChecklist(this ItineraryChecklistDTO dto)
        {
            return new ItineraryChecklist
            {
                ID = dto.ID,
                ItineraryDaySectionId = dto.ItineraryDaySectionId,
                ItineraryHeader = dto.ItineraryHeader,
                ItineraryChecklistItems = dto.ItineraryChecklistItems?.Select(i => i.ToItineraryChecklistItem()).ToList()
            };
        }

        public static ItineraryChecklistItem ToItineraryChecklistItem(this ItineraryChecklistItemDTO dto)
        {
            return new ItineraryChecklistItem
            {
                ID = dto.ID,
                ItineraryChecklistId = dto.ItineraryChecklistId,
                ItemDescription = dto.ItemDescription
            };
        }
    }
}
