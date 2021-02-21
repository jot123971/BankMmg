using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BankMmg.Data;
using BankMmg.Models;

namespace BankMmg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankSystemsController : ControllerBase
    {
        private readonly BankMmgContext _context;

        public BankSystemsController(BankMmgContext context)
        {
            _context = context;
        }

        // GET: api/BankSystems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BankSystem>>> GetBankSystem()
        {
            return await _context.BankSystem.ToListAsync();
        }

        // GET: api/BankSystems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BankSystem>> GetBankSystem(int id)
        {
            var bankSystem = await _context.BankSystem.FindAsync(id);

            if (bankSystem == null)
            {
                return NotFound();
            }

            return bankSystem;
        }

        // PUT: api/BankSystems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBankSystem(int id, BankSystem bankSystem)
        {
            if (id != bankSystem.ID)
            {
                return BadRequest();
            }

            _context.Entry(bankSystem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BankSystemExists(id))
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

        // POST: api/BankSystems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BankSystem>> PostBankSystem(BankSystem bankSystem)
        {
            _context.BankSystem.Add(bankSystem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBankSystem", new { id = bankSystem.ID }, bankSystem);
        }

        // DELETE: api/BankSystems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BankSystem>> DeleteBankSystem(int id)
        {
            var bankSystem = await _context.BankSystem.FindAsync(id);
            if (bankSystem == null)
            {
                return NotFound();
            }

            _context.BankSystem.Remove(bankSystem);
            await _context.SaveChangesAsync();

            return bankSystem;
        }

        private bool BankSystemExists(int id)
        {
            return _context.BankSystem.Any(e => e.ID == id);
        }
    }
}
