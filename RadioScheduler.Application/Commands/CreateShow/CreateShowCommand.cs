using MediatR;

namespace RadioScheduler.Application.Commands;

public class CreateShowCommand : IRequest<Guid>
{
    public string Title { get; set; } = default!;
    public string Presenter { get; set; } = default!;
    public DateTime StartTime { get; set; }
    public int DurationMinutes { get; set; }
}