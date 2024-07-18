using API_AutoPerfecto.db;
using API_AutoPerfecto.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class AutosController : ControllerBase
{
    private readonly AutosContext _context;

    public AutosController(AutosContext context)
    {
        _context = context;
    }

    // GET: api/Vehicles
    [HttpGet]
    public async Task<ActionResult<object>> GetVehicles()
    {
        var vehicles = await _context.Vehicles.ToListAsync();

        if (vehicles == null || vehicles.Count == 0)
        {
            return NotFound();
        }

        // Crear la estructura con "results"
        var results = vehicles.Select(v => new
        {
            id = v.id.ToString(),
            Make = v.make,
            Model = v.model,
            year = v.year.ToString(),
            Vclass = v.vclass,
            Trany = v.trany,
            Cylinders = v.cylinders,
            Drive = v.drive,
            engid = v.engid.ToString(),
            Fueltype = v.fueltype,
            Image = v.image
        }).ToList();

        return new { results };
    }

    // GET: api/Vehicles/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Auto>> GetVehicle(string id)
    {
        var vehicle = await _context.Vehicles.FindAsync(id);

        if (vehicle == null)
        {
            return NotFound();
        }

        return vehicle;
    }

    // POST: api/Vehicles
    [HttpPost]
    public async Task<ActionResult<Auto>> PostVehicle(Auto auto)
    {
        _context.Vehicles.Add(auto);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetVehicle", new { Id = auto.id }, auto);
    }
}
