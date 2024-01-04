using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmployeeDetails.Model;

namespace EmployeeDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesiginationController : ControllerBase
    {
        private readonly EmployeeContext _context;

        public DesiginationController(EmployeeContext context)
        {
            _context = context;
        }

        // GET: api/Desiginations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblDesignation>>> GetTblDesignation()
        {
            return await _context.TblDesignation.ToListAsync();
        }

        // GET: api/Desiginations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblDesignation>> GetTblDesignation(int id)
        {
            var TblDesignation = await _context.TblDesignation.FindAsync(id);

            if (TblDesignation == null)
            {
                return NotFound();
            }

            return TblDesignation;
        }

        // PUT: api/Desiginations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblDesignation(int id, TblDesignation TblDesignation)
        {
            if (id != TblDesignation.Id)
            {
                return BadRequest();
            }

            _context.Entry(TblDesignation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblDesignationExists(id))
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

        // POST: api/Desiginations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TblDesignation>> PostTblDesignation(TblDesignation TblDesignation)
        {
            _context.TblDesignation.Add(TblDesignation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblDesignation", new { id = TblDesignation.Id }, TblDesignation);
        }

        // DELETE: api/Desiginations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblDesignation(int id)
        {
            var TblDesignation = await _context.TblDesignation.FindAsync(id);
            if (TblDesignation == null)
            {
                return NotFound();
            }

            _context.TblDesignation.Remove(TblDesignation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TblDesignationExists(int id)
        {
            return _context.TblDesignation.Any(e => e.Id == id);
        }
    }
}
