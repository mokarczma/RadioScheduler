using RadioScheduler.Application.Interfaces;
using RadioScheduler.Domain.Entities;
using RadioScheduler.Infrastructure.Persistence;


namespace RadioScheduler.Infrastructure.Repositories
{
    public class ShowRepository : IShowRepository
    {
        private readonly RadioSchedulerDbContext _context;

        public ShowRepository(RadioSchedulerDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> AddShowAsync(Show show)
        {
            _context.Shows.Add(show);
            await _context.SaveChangesAsync();
            return show.Id;
        }
    }
}
