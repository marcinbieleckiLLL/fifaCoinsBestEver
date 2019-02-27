using fifaCoinsBestEver.dte;

namespace fifaCoinsBestEver.Models
{
    public class Product : AModel
    {
        public string name { get; set; }
        public long price { get; set; }
        public long quantity { get; set; }
        public ProductType productType { get; set; }
        public Transaction transaction { get; set; }
    }
}