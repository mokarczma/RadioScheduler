namespace RadioScheduler.Domain.Entities;

public class Show
{
    public Guid Id { get; set; }
    public string Title { get; set; } = default!;
    public string Presenter { get; set; } = default!;
    public DateTime StartTime { get; set; }
    public int DurationMinutes { get; set; }

    public DateTime EndTime => StartTime.AddMinutes(DurationMinutes);
}
