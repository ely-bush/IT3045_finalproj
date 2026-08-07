using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IT3045_finalproj.Data;
using IT3045_finalproj.Models;


namespace IT3045_finalproj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamMembersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TeamMembersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamMember>>> GetTeamMembers()
        {
            return await _context.TeamMembers.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TeamMember>> GetTeamMember(int id)
        {
            var teamMember = await _context.TeamMembers.FindAsync(id);
            if (teamMember == null)
            {
                return NotFound();
            }
            return teamMember;
        }

        [HttpPost]
        public async Task<ActionResult<TeamMember>> PostTeamMember(TeamMember teamMember)
        {
            _context.TeamMembers.Add(teamMember);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTeamMember), new { id = teamMember.TeamMemberID }, teamMember);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeamMember(int id, TeamMember teamMember)
        {
            if (id != teamMember.TeamMemberID)
            {
                return BadRequest();

                _context.Entry(teamMember).state = EntityState.Modified;

                try
                { 
                    await _context.SaveChangesAsync();
                }

                catch (DbUpdateConcurrencyException)
                {
                    if (!TeamMemberExists(id))
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
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeamMember(int id)
        {
            var teamMember = await _context.TeamMembers.FindAsync(id);
            if (teamMember == null)
            {
                return NotFound();
            }
            _context.TeamMembers.Remove(teamMember);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
