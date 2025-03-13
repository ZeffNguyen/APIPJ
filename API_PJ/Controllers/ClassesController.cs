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
    public class ClassesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ClassesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Classes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Class>>> GetClasses()
        {
            return await _context.Classes.ToListAsync();
        }

        [HttpGet("get-by-teacher/{teacherId}")]
        public async Task<ActionResult<IEnumerable<Class>>> GetClassesByTeacher(Guid teacherId)
        {
            var classes = await _context.Classes
                                        .Where(c => c.MainTeacherId == teacherId)
                                        .ToListAsync();

            if (!classes.Any())
            {
                return NotFound("No classes found for this teacher.");
            }

            return Ok(classes);
        }

        [HttpGet("get-id-by-name/{className}")]
        public async Task<ActionResult<Guid>> GetClassIdByName(string className)
        {
            var classEntity = await _context.Classes
                                            .Where(c => EF.Functions.Like(c.ClassName, className))
                                            .Select(c => c.ClassId)
                                            .FirstOrDefaultAsync();

            if (classEntity == Guid.Empty)
            {
                return NotFound("Class not found");
            }

            return Ok(classEntity);
        }


        // GET: api/Classes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Class>> GetClass(Guid id)
        {
            var @class = await _context.Classes.FirstOrDefaultAsync(c => c.ClassId == id);

            if (@class == null)
            {
                return NotFound();
            }

            return @class;
        }



        // PUT: api/Classes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClass(Guid id, Class @class)
        {
            if (id != @class.ClassId)
            {
                return BadRequest();
            }

            _context.Entry(@class).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassExists(id))
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

        // POST: api/Classes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Class>> PostClass(Class @class)
        {
            _context.Classes.Add(@class);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClass", new { id = @class.ClassId }, @class);
        }

        // DELETE: api/Classes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClass(Guid id)
        {
            var @class = await _context.Classes.FindAsync(id);
            if (@class == null)
            {
                return NotFound();
            }

            _context.Classes.Remove(@class);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClassExists(Guid id)
        {
            return _context.Classes.Any(e => e.ClassId == id);
        }
    }
}
