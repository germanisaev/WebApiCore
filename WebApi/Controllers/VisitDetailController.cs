using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Model;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitDetailController : ControllerBase
    {
        private readonly VisitDetailContext _context;

        public VisitDetailController(VisitDetailContext context)
        {
            _context = context;
        }

        // GET: api/VisitDetail
        [HttpGet]
        public IEnumerable<VisitDetail> GetVisitDetails()
        {
            return _context.VisitDetails;
        }

        // GET: api/VisitDetail/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVisitDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var visitDetail = await _context.VisitDetails.FindAsync(id);

            if (visitDetail == null)
            {
                return NotFound();
            }

            return Ok(visitDetail);
        }

        // PUT: api/VisitDetail/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVisitDetail([FromRoute] int id, [FromBody] VisitDetail visitDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != visitDetail.QueueId)
            {
                return BadRequest();
            }

            _context.Entry(visitDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VisitDetailExists(id))
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

        // POST: api/VisitDetail
        [HttpPost]
        public async Task<IActionResult> PostVisitDetail([FromBody] VisitDetail visitDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.VisitDetails.Add(visitDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVisitDetail", new { id = visitDetail.QueueId }, visitDetail);
        }

        // DELETE: api/VisitDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVisitDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var visitDetail = await _context.VisitDetails.FindAsync(id);
            if (visitDetail == null)
            {
                return NotFound();
            }

            _context.VisitDetails.Remove(visitDetail);
            await _context.SaveChangesAsync();

            return Ok(visitDetail);
        }

        private bool VisitDetailExists(int id)
        {
            return _context.VisitDetails.Any(e => e.QueueId == id);
        }
    }
}