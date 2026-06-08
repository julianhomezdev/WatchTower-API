namespace WatchTower_API.Domain;

public class Monitor
{
    
    public Guid Id { get; set; }
    
    public string Name  { get; set; } = string.Empty;

    public string Url { get; set; } = string.Empty;
    
    public bool IsActive { get; set; }
    
    public DateTime CreatedAt { get; set; }


}