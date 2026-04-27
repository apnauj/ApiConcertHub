using ApiConcertHub.Models;

namespace ApiConcertHub.Interfaces;

public interface IEventService
{
    Task <List<Event>> GetAll();
    Task <Event> GetById(Guid id);
    Task <Event> Create(Event newEvent);
    Task<bool> Edit(Guid id, Event editEvent);
}