using ApiConcertHub.Models;

namespace ApiConcertHub.Interfaces;

public interface IEventService
{
    Task <List<Event>> GetAll();
}