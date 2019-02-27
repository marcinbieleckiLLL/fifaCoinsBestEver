using fifaCoinsBestEver.dte;

namespace fifaCoinsBestEver.Models {
    public class User : AModel{
        
        public string username { get; set; }  
        public string email { get; set; }  
        public string pwd { get; set; }
        public UserRoleType type { get; set; }
        public Customer customer { get; set; }
    }
}