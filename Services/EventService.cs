using ApiConcertHub.DAO;
using ApiConcertHub.Interfaces;
using ApiConcertHub.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApiConcertHub.Services;

public class EventService: IEventService
{
    private readonly ApplicationDbContext _context;

    public EventService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Event>> GetAll()
    {
        return await _context.Events.Where(e => e.IsActive == 1).ToListAsync();
    }
}