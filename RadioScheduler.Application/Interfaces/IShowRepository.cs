using RadioScheduler.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace RadioScheduler.Application.Interfaces
{
    public interface IShowRepository
    {
        Task<Guid> AddShowAsync(Show show);
    }
}
