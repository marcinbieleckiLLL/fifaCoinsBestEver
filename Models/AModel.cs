using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fifaCoinsBestEver.Models
{
    public class AModel
    {
        [Key]  
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  
        public long id { get; set; } 
        public DateTime? modDate { get; set; }  
    }
}