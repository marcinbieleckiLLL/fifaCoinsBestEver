using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using fifaCoinsBestEver.dte;

namespace fifaCoinsBestEver.Models {
    public class User {
        [Key]  
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  
        public long userId { get; set; }  
        public string username { get; set; }  
        public string pwd { get; set; }    
        public DateTime? modDate { get; set; }  
        public UserRoleType type { get; set; }
    }
}