﻿using System;
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
    public class SchedulesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SchedulesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Schedules
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Schedule>>> GetSchedules()
        {
            return await _context.Schedules.ToListAsync();
        }

        // GET: api/Schedules/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Schedule>> GetSchedule(Guid id)
        {
            var schedule = await _context.Schedules.FindAsync(id);

            if (schedule == null)
            {
                return NotFound();
            }

            return schedule;
        }

        // PUT: api/Schedules/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSchedule(Guid id, Schedule schedule)
        {
            if (id != schedule.ScheduleId)
            {
                return BadRequest();
            }

            _context.Entry(schedule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScheduleExists(id))
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

        // POST: api/Schedules
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Schedule>> PostSchedule(Schedule schedule)
        {
            _context.Schedules.Add(schedule);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSchedule", new { id = schedule.ScheduleId }, schedule);
        }

        // DELETE: api/Schedules/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSchedule(Guid id)
        {
            var schedule = await _context.Schedules.FindAsync(id);
            if (schedule == null)
            {
                return NotFound();
            }

            _context.Schedules.Remove(schedule);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpGet("get-id-by-room/{room}")]
        public async Task<ActionResult<Guid>> GetScheduleIdByRoom(string room)
        {
            var schedule = await _context.Schedules
                                         .Where(s => EF.Functions.Like(s.Room, room))
                                         .Select(s => s.ScheduleId)
                                         .FirstOrDefaultAsync();

            if (schedule == Guid.Empty)
            {
                return NotFound("Schedule not found");
            }

            return Ok(schedule);
        }

        [HttpGet("get-id-by-class/{classId}")]
        public async Task<ActionResult<Guid>> GetScheduleIdByClass(Guid classId)
        {
            var schedule = await _context.Schedules
                                         .Where(s => s.ClassId == classId)
                                         .Select(s => s.ScheduleId)
                                         .FirstOrDefaultAsync();

            if (schedule == Guid.Empty)
            {
                return NotFound("Schedule not found");
            }

            return Ok(schedule);
        }

        [HttpGet("get-id-by-subject/{subjectId}")]
        public async Task<ActionResult<Guid>> GetScheduleIdBySubject(Guid subjectId)
        {
            var schedule = await _context.Schedules
                                         .Where(s => s.SubjectId == subjectId)
                                         .Select(s => s.ScheduleId)
                                         .FirstOrDefaultAsync();

            if (schedule == Guid.Empty)
            {
                return NotFound("Schedule not found");
            }

            return Ok(schedule);
        }

        [HttpGet("get-id-by-teacher/{teacherId}")]
        public async Task<ActionResult<Guid>> GetScheduleIdByTeacher(Guid teacherId)
        {
            var schedule = await _context.Schedules
                                         .Where(s => s.TeacherId == teacherId)
                                         .Select(s => s.ScheduleId)
                                         .FirstOrDefaultAsync();

            if (schedule == Guid.Empty)
            {
                return NotFound("Schedule not found");
            }

            return Ok(schedule);
        }

        private bool ScheduleExists(Guid id)
        {
            return _context.Schedules.Any(e => e.ScheduleId == id);
        }
    }
}
