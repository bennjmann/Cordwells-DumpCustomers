using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cordwell.EmailService.Webapp.Models {
    [Table("customer")]
    public class Customer {
        public string customerId { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string emailTwo { get; set; }
        public ICollection<Order>? orders { get; set; } = new List<Order>();

    }
}