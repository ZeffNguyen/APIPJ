using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_PJ.Data;
using API_PJ.Models;

namespace API_PJ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportCardsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ReportCardsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ReportCards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReportCard>>> GetReportCards()
        {
            return await _context.ReportCards.ToListAsync();
        }

        // GET: api/ReportCards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReportCard>> GetReportCard(Guid id)
        {
            var reportCard = await _context.ReportCards.FindAsync(id);

            if (reportCard == null)
            {
                return NotFound();
            }

            return reportCard;
        }

        // PUT: api/ReportCards/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReportCard(Guid id, ReportCard reportCard)
        {
            if (id != reportCard.ReportId)
            {
                return BadRequest();
            }

            _context.Entry(reportCard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReportCardExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ReportCards
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ReportCard>> PostReportCard(ReportCard reportCard)
        {
            _context.ReportCards.Add(reportCard);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReportCard", new { id = reportCard.ReportId }, reportCard);
        }

        // DELETE: api/ReportCards/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReportCard(Guid id)
        {
            var reportCard = await _context.ReportCards.FindAsync(id);
            if (reportCard == null)
            {
                return NotFound();
            }

            _context.ReportCards.Remove(reportCard);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReportCardExists(Guid id)
        {
            return _context.ReportCards.Any(e => e.ReportId == id);
        }
    }
}
