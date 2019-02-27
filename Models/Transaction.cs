using System;

namespace fifaCoinsBestEver.Models
{
    public class Transaction : AModel
    {
        public Customer customer { get; set; }
        public Boolean isPaid { get; set; }
        public DateTime? from { get; set; }
        public DateTime? to { get; set; }
        
        public long productId { get; set; }
        public Product product { get; set; }
    }
}