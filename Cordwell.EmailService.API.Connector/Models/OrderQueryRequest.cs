namespace Cordwell.EmailService.API.Connector.Models;

public class OrderQueryRequest
{
    public DateTime? FromOrderDate { get; set; }
    public bool ShouldSerializeFromOrderDate()
    {
        return FromOrderDate.HasValue;
    }
    public DateTime? ToOrderDate { get; set; }
    public bool ShouldSerializeToOrderDate()
    {
        return ToOrderDate.HasValue;
    }
    
    public String? IncludeRetElement { get; set; }
    
}