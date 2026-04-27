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

    public async Task<Event> GetById(Guid id)
    {
        return await _context.Events.FindAsync(id);
    }

    public async Task<Event> Create(Event newEvent)
    {
        _context.Events.Add(newEvent);
        await _context.SaveChangesAsync();
        return newEvent;
    }
}