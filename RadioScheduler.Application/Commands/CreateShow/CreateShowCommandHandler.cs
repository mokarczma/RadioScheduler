using MediatR;
using RadioScheduler.Application.Commands;
using RadioScheduler.Application.Interfaces;
using RadioScheduler.Domain.Entities;

public class CreateShowCommandHandler : IRequestHandler<CreateShowCommand, Guid>
{
    private readonly IShowRepository _showRepository;

    public CreateShowCommandHandler(IShowRepository showRepository)
    {
        _showRepository = showRepository;
    }

    public async Task<Guid> Handle(CreateShowCommand request, CancellationToken cancellationToken)
    {
        var show = new Show
        {
            Title = request.Title,
            Presenter = request.Presenter,
            StartTime = request.StartTime,
            DurationMinutes = request.DurationMinutes
        };

        return await _showRepository.AddShowAsync(show);
    }
}