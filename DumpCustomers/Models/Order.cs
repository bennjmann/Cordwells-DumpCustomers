using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cordwell.EmailService.Webapp.Models {
    
    public enum EmailStatus
    { 
        NOTSENT = 0,
        SENT = 1,
        ERROR = 2,
    }
    
    
    [Table("order")]
    public class Order {
        
        public int? orderId { get; set; }
        public DateTime date { get; set; }
        public Customer customer { get; set; } = null!;

    }
}