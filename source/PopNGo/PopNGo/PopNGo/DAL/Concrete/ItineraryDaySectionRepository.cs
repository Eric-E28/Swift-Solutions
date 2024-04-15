using Microsoft.EntityFrameworkCore;
using PopNGo.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PopNGo.Repositories
{
    public class ItineraryDaySectionRepository : IItineraryDaySectionRepository
    {
        private readonly PopNGoDB _context;

        public ItineraryDaySectionRepository(PopNGoDB context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ItineraryDaySection>> GetAllAsync()
        {
            try
            {
                return await _context.ItineraryDaySections
                    .Include(i => i.ItineraryChecklists)
                        .ThenInclude(ic => ic.ItineraryChecklistItems)
                    .AsNoTracking()
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                // Log exception (consider logging the exception details here)
                throw new Exception("An error occurred while retrieving all itinerary day sections", ex);
            }
        }

        public async Task<ItineraryDaySection> GetByIdAsync(int id)
        {
            try
            {
                var section = await _context.ItineraryDaySections
                    .Include(i => i.ItineraryChecklists)
                        .ThenInclude(ic => ic.ItineraryChecklistItems)
                    .FirstOrDefaultAsync(i => i.ID == id);

                if (section == null)
                {
                    throw new KeyNotFoundException("ItineraryDaySection not found for the given ID.");
                }

                return section;
            }
            catch (Exception ex)
            {
                // Log exception
                throw new Exception("An error occurred while retrieving an itinerary day section", ex);
            }
        }

        public async Task<(ItineraryDaySection, bool)> UpsertAsync(ItineraryDaySection section)
        {
            if (section == null)
                throw new ArgumentNullException(nameof(section));

            var existingSection = await _context.ItineraryDaySections
                .Include(s => s.ItineraryChecklists)
                    .ThenInclude(ic => ic.ItineraryChecklistItems)
                .AsNoTracking() // Ensure we do not track the query results to handle updates manually
                .FirstOrDefaultAsync(s => s.ID == section.ID);

            bool wasCreated = false;
            if (existingSection == null)
            {
                // No existing section found, add a new section
                _context.ItineraryDaySections.Add(section);
                wasCreated = true;
            }
            else
            {
                // An existing section is found, manually handle the update
                _context.Entry(existingSection).State = EntityState.Detached; // Detach the original entity if it was tracked
                _context.Entry(section).State = EntityState.Modified; // Attach the new entity and mark it as modified

                // Handle collections (ItineraryChecklists and their Items)
                foreach (var checklist in section.ItineraryChecklists)
                {
                    var existingChecklist = existingSection.ItineraryChecklists
                        .FirstOrDefault(ic => ic.ID == checklist.ID);

                    if (existingChecklist == null)
                    {
                        // New checklist, add it
                        existingSection.ItineraryChecklists.Add(checklist);
                    }
                    else
                    {
                        // Existing checklist, update it
                        _context.Entry(existingChecklist).CurrentValues.SetValues(checklist);

                        // Handle checklist items
                        foreach (var item in checklist.ItineraryChecklistItems)
                        {
                            var existingItem = existingChecklist.ItineraryChecklistItems
                                .FirstOrDefault(ii => ii.ID == item.ID);

                            if (existingItem == null)
                            {
                                // New item, add it
                                existingChecklist.ItineraryChecklistItems.Add(item);
                            }
                            else
                            {
                                // Existing item, update it
                                _context.Entry(existingItem).CurrentValues.SetValues(item);
                            }
                        }

                        // Clean up any removed items
                        existingChecklist.ItineraryChecklistItems
                            .Where(ii => !checklist.ItineraryChecklistItems.Any(i => i.ID == ii.ID))
                            .ToList()
                            .ForEach(itemToRemove => _context.ItineraryChecklistItems.Remove(itemToRemove));
                    }
                }

                // Clean up any removed checklists
                existingSection.ItineraryChecklists
                    .Where(ic => !section.ItineraryChecklists.Any(c => c.ID == ic.ID))
                    .ToList()
                    .ForEach(checklistToRemove => _context.ItineraryChecklists.Remove(checklistToRemove));
            }

            await _context.SaveChangesAsync();
            return (section, wasCreated);
        }
    }
}
