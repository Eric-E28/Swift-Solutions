using Microsoft.AspNetCore.Mvc;
using PopNGo.Models.DTO;
using PopNGo.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PopNGo.Extensions;

namespace PopNGo.Controllers
{
    [Route("api/itinerarydaysections")]
    [ApiController]
    public class ItineraryDaySectionController : ControllerBase
    {
        private readonly IItineraryDaySectionRepository _itineraryDaySectionRepository;

        public ItineraryDaySectionController(IItineraryDaySectionRepository itineraryDaySectionRepository)
        {
            _itineraryDaySectionRepository = itineraryDaySectionRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItineraryDaySectionDTO>>> GetAllItineraryDaySections()
        {
            try
            {
                var sections = await _itineraryDaySectionRepository.GetAllAsync();
                if (!sections.Any())
                    return NotFound("No itinerary day sections found.");

                return Ok(sections.Select(s => s.ToDTO()).ToList());
            }
            catch (Exception ex)
            {
                // Log the exception details here using a logging framework (e.g., Serilog, NLog)
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ItineraryDaySectionDTO>> GetItineraryDaySection(int id)
        {
            try
            {
                var section = await _itineraryDaySectionRepository.GetByIdAsync(id);
                if (section == null)
                    return NotFound($"ItineraryDaySection with ID {id} not found.");

                return Ok(section.ToDTO());
            }
            catch (Exception ex)
            {
                // Log the exception details here
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }

        [HttpPost]
        public async Task<ActionResult<ItineraryDaySectionDTO>> UpsertItineraryDaySection([FromBody] ItineraryDaySectionDTO dto)
        {
            if (dto == null)
                return BadRequest("Invalid data provided.");

            try
            {
                var sectionModel = dto.ToItineraryDaySection();

                // UpsertAsync should return a tuple containing the model and a bool flag indicating if it was created
                var (upsertedSection, wasCreated) = await _itineraryDaySectionRepository.UpsertAsync(sectionModel);

                // Convert model back to DTO for response
                var resultDto = upsertedSection.ToDTO();

                // Conditionally return response based on the operation performed
                return wasCreated
                    ? CreatedAtAction(nameof(GetItineraryDaySection), new { id = resultDto.ID }, resultDto)
                    : Ok(resultDto);
            }
            catch (Exception ex)
            {
                // Consider logging the exception before returning a response
                return StatusCode(500, "An error occurred while processing your request: " + ex.Message);
            }
        }

    }
}
