namespace WatchTower_API.Domain;

public class MonitorCheck
{
    
    public Guid Id { get; set; }
    
    public Guid MonitorId { get; set; }
    
    public int StatusCode { get; set; }
    
    public long ResponseTimeMs { get; set; }
    
    public bool IsSuccess { get; set; }
    
    public DateTime CheckedAt { get; set; }
    
    
    
}