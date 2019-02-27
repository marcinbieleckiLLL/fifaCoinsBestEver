using System.Collections.Generic;

namespace fifaCoinsBestEver.Models
{
    public class Customer : AModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string dateOfBirth { get; set; }
        
        public long userId { get; set; }
        public User user { get; set; }
        
        public List<Transaction> transactions { get; set; }
    }
}